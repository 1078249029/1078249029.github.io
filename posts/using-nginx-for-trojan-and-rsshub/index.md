# nginx反向代理trojan与rsshub

# nginx反向代理trojan与rsshub  

最终效果：外网通过rss.domin.top访问rsshub服务，通过free.domin.top访问trojan服务，通过free.domin.top/admin访问trojan-web管理服务。内部使用docker隔离包括nginx在内的所有服务  

## 前置准备  

### 购买服务器及域名  

可以从主流的服务器提供商购买服务器以及域名，我选择的服务器厂商是雨云(国际厂商可以选择racknerd或VMISS)，域名提供商是namesilo

购买完毕后需要在国内DNS解析服务器上绑定ip与域名，可以选择腾讯DNS解析服务。绑定格式如下，需要注意的是我这里使用的二级域名需要额外在namesilo生成
![2024-10-19_13-49](/vx_images/555814913252497.png)  

![2024-10-19_13-52](/vx_images/355505213270377.png)
这里记录值改为ip地址即可

### 初始化服务器  

我的系统是Ubuntu22.04，预安装宝塔面板。安装系统完成并进入宝塔面板后，需要下载docker  

## 正式搭建

### 部署nginx容器

我这里使用的是[dockerhub上的官方版本](https://hub.docker.com/_/nginx/tags)

首先拉取镜像到本地
```shell
docker pull nginx:stable-perl
```
而后可以在宝塔面板中看到
![2024-10-19_11-13](/vx_images/462651311247353.png)
这里我们也可以点击创建容器也可以通过命令
```cpp
docker run -d -p 443:443 -p 80::80 --net bridge --name nginx nginx:latest
```
图形化创建容器时需要映射80以及443端口，同时指定容器网络为桥接(指定网络为host后在下文的docker网络配置环节可能会连接不上其他容器网络)
![2024-10-19_11-17](/vx_images/86511811267519.png)

![2024-10-19_11-20](/vx_images/178002011260188.png)

### 部署rsshub容器

这里可以参考[官方文档](https://docs.rsshub.app/zh/deploy/#docker-compose-%E9%83%A8%E7%BD%B2-%E6%8E%A8%E8%8D%90)使用docker compose部署

下载docker compose文件(可以理解为docker的配置文件)
```shell
wget https://raw.githubusercontent.com/DIYgod/RSSHub/master/docker-compose.yml
```

启动容器(通过docker compose文件下载相关的包并配置参数，完成后启动容器)
```shell
docker-compose up -d
```

在漫长的下载过程后会在面板中看到如下三个容器  
![2024-10-19_11-27](/vx_images/375582711256743.png)

这里我映射了1200端口是为了测试用，各位如果不需要测试的话可以不用配置

假如你和我一样保留了1200测试端口，此时我们访问ip:1200端口就可以访问rsshub了，如果404可能是你防火墙没有开，面板中的安全菜单中可以自行配置

### 部署trojan容器

这里我们选用[jroh大佬的trojan镜像](https://hub.docker.com/r/jrohy/trojan)  

安装trojan之前最好先安装trojan-web服务，因为安装trojan的时候会需要指定trojan-web数据库的ip地址，不指定可能会安装失败
```cpp
docker run --name trojan-mariadb --restart=always -p 3306:3306 -v /home/mariadb:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=trojan -e MYSQL_ROOT_HOST=% -e MYSQL_DATABASE=trojan -d mariadb:10.2
```
注意MYSQL_ROOT_PASSWORD=trojan参数，这里我们下面安装trojan时需要输入数据库的密码就是trojan

之后我们拉取trojan的镜像
```shell
docker pull jrohy/trojan
```

**注意本次trojan使用桥接网络，这与jrohy大佬提供的命令不同**，因此不需要将端口映射到主机，但为了后需的调整，我们这里预留4431和4432端口
```shell
docker run -it -d --name trojan --net=bridge --restart=always --privileged jrohy/trojan init
```

生成容器后我们进入容器
```shell
docker exec -it trojan bash
```

此时我们需要安装trojan，shell中输入trojan就行了
```shell
trojan
```

此时会进入安装界面，证书选择let's encrpt证书，域名绑定到服务商域名，此时会需要指定mysql或mariadb的ip和端口号，这里我们可以通过查看容器网络获得也可以给空之后修改(给空有可能安装错误)。这里如果你没有看到桥接网络的话需要设置mariadb网络为桥接bridge，默认端口号是3306，因此我这里的结果是172.17.0.4:3306

![2024-10-19_13-57](/vx_images/528665713267981.png)

之后等待安装完成就可

别忘了启动服务，设置自启动以及更新程序
```shell
systemctl start trojan-web

systemctl enable trojan-web

source <(curl -sL https://git.io/trojan-install)
```

最后退出容器
```cpp
exit
```

目前你的容器情况可能如下
![2024-10-19_14-01](/vx_images/39770214265483.png)

我们需要指定rsshub为桥接，这样才能使用nginx将流量转发到rsshub，桥接时务必保留原有的rsshub容器网络

接下来我们进行反向代理的配置


### 申请证书  

在配置反向代理前我们需要准备证书，这也是我们刚才在安装mariadb时跳过的步骤

申请证书很简单，但需要提前获取ip以及域名，申请过程可以参考[Diaoan's Blog](https://www.diaoan.xyz/using-certbot-apply-ssl-certificate/)

我这里直接执行
```shell
certbot certonly --standalone -d rss.domain.top
```

```shell
certbot certonly --standalone -d free.domain.top
```

记录好证书存放位置，之后我们正式开始进行反向代理的配置

### 网络拓扑图

反向代理要搞清网络是非常有必要的，我当前网络拓扑图是这样的
![服务器网络拓扑当前](/vx_images/37634416260188.png)

而我们目标的网络拓扑是这样的：nginx容器接管一切流量并将其转发到对应应用
![服务器网络拓扑目标](/vx_images/127214416256743.png)

由此可见，我们应该配置trojan的两个个端口，nginx的两个端口。trojan两个端口的作用可以看[官方文档](https://p4gefau1t.github.io/trojan-go/basic/trojan/)，简而言之，近端端口用来进行代理，远端端口用来检测到非法连接从而将非法流量转移到此端口上，因此这个端口可以设置为任意能够ping通的网页。而为了保证流量均由nginx控制，这里采用通过nginx转发trojan远程端口以及管理页面，同时由于远程端口可以任意指定，这里就把管理页面作为远程端口。传输协议方面，由于trojan配置文件需要指定证书文件，因此对于ssl协议的解析需要放在trojan容器内部进行，而rss内部没有解析的功能，我们就需要在nginx内部进行协议的处理

### 修改nginx配置项

首先保证nginx，rsshub，trojan均为桥接，保证在同一个容器网络中

而后修改nginx容器内的`/etc/nginx/nginx.conf`文件内容如下
```shell

user  nginx;
worker_processes  auto;

error_log  /var/log/nginx/error.log notice;
pid        /var/run/nginx.pid;

events {
    worker_connections  1024;
}

# 流量转发核心配置
stream {
    # SNI 识别，将域名映射到具体服务
    map $ssl_preread_server_name $backend_name {
        free.wumingzi.top trojan;   # Trojan 流量转发
        rss.wumingzi.top rss;       # rsshub流量转发
        default rss;                # 默认转发到 RSS (避免误匹配)
    }

    # 定义 Trojan 的后端服务
    upstream trojan {
        server 172.17.0.5:4431;  # Trojan 的后端端口
    }

    upstream rss {
        server 127.0.0.1:1201;   # 这里需要先转到nginx容器的1201端口进行ssl协议处理，处理完成后再转到rsshub容器的1200端口
    }

    # 监听 443 并使用 ssl_preread 对 Trojan 流量转发，不解密
    server {
        listen 443 reuseport;
        listen [::]:443 reuseport;
        proxy_pass $backend_name;
        ssl_preread on;
    }
}

http {
    include       /etc/nginx/mime.types;
    default_type  application/octet-stream;

    log_format  main  '$remote_addr - $remote_user [$time_local] "$request" '
                      '$status $body_bytes_sent "$http_referer" '
                      '"$http_user_agent" "$http_x_forwarded_for"';

    access_log  /var/log/nginx/access.log  main;

    sendfile        on;
    #tcp_nopush     on;

    keepalive_timeout  65;

    #gzip  on;

    include /etc/nginx/conf.d/*.conf;
    
    # 如果端口设置与stream块相同的话就会导致冲突，因此这里只能监听http协议的80而不能监听https的443
    server {
        listen 80;
        server_name rss.wumingzi.top;
        return 301 https://$host$request_uri; # 永久重定向为https
    }
    server {
        listen 1201 ssl;
        server_name rss.wumingzi.top;
        # 证书解析，上文申请的证书放到容器内的对应位置
        ssl_certificate /etc/nginx/certs/rss.wumingzi.top/fullchain1.pem;
        ssl_certificate_key /etc/nginx/certs/rss.wumingzi.top/privkey1.pem;
        location / {
          proxy_pass http://172.17.0.3:1200; # 转到rsshub容器的1200端口，此时需要解析协议，因此是http
        }
  	}
  	
  	server {
        listen 82; # 监听trojan的远程端口，有流量产生时转发到对应服务
    
        server_name free.wumingzi.top;

        # 后台管理页面,通过 free.wumingzi.top/admin 访问
        location /admin {
            proxy_pass   http://172.17.0.5:81/; # 将trojan已经解析的协议发送到nginx容器的81端口这里是trojan-web的协议端口
        }
    
        # 由于 trojan web 前端的部分资源是写在二进制中的，这些资源的访问路径固定
        location ~* ^/(static|common|auth|trojan)/ {
            proxy_pass  http://172.17.0.5:81; 
            proxy_http_version 1.1;
            proxy_set_header Upgrade $http_upgrade;
            proxy_set_header Connection "Upgrade";
            proxy_set_header Host $host;
        } 
    }
}
```

### 修改trojan配置项

将trojan容器中的`/usr/local/etc/trojan/config.json`文件修改如下
```json
{
  "run_type": "server",
  "local_addr": "0.0.0.0",
  "local_port": 4431,    //修改本地端口为nginx配置的转发端口
  "remote_addr": "172.17.0.2",    //修改远程ip为nginx容器的ip
  "remote_port": 82,    //修改远程端口为nginx的远程端口
  "password": null,
  "log_level": 1,    //这里可以加上日志文件方便调试
  "ssl": {    //修改为对应的证书
    "cert": "/usr/local/etc/trojan/certs/free.wumingzi.top/fullchain1.pem",
    "key": "/usr/local/etc/trojan/certs/free.wumingzi.top/privkey1.pem",
    "key_password": "",
    "cipher": "ECDHE-ECDSA-AES128-GCM-SHA256:ECDHE-RSA-AES128-GCM-SHA256:ECDHE-ECDSA-AES256-GCM-SHA384:ECDHE-RSA-AES256-GCM-SHA384:ECDHE-ECDSA-CHACHA20-POLY1305:ECDHE-RSA-CHACHA20-POLY1305:DHE-RSA-AES128-GCM-SHA256:DHE-RSA-AES256-GCM-SHA384",
    "cipher_tls13": "TLS_AES_128_GCM_SHA256:TLS_CHACHA20_POLY1305_SHA256:TLS_AES_256_GCM_SHA384",
    "prefer_server_cipher": true,
    "alpn": ["http/1.1"],
    "alpn_port_override": {
      "h2": 81
    },
    "reuse_session": true,
    "session_ticket": false,
    "session_timeout": 600,
    "plain_http_response": "",
    "curves": "",
    "dhparam": "",
    "sni": "free.wumingzi.top"    //这里修改为nginx配置的流量转发的网址
  },
  "tcp": {
    "prefer_ipv4": false,
    "no_delay": true,
    "keep_alive": true,
    "reuse_port": false,
    "fast_open": false,
    "fast_open_qlen": 20
  },
  "mysql": {
    "enabled": true,
    "server_addr": "172.17.0.4",    //修改为mariadb容器的ip
    "server_port": 3306,    //修改为mariadb容器对应的端口号
    "database": "trojan",    //下面视情况修改
    "username": "root",
    "password": "trojan",
    "cafile": ""
  }
}
```

将trojan中的`/etc/systemd/system/trojan-web.service `文件修改如下，第九行新增指定81端口运行
```json
[Unit]
Description=trojan-web
Documentation=https://github.com/Jrohy/trojan
After=network.target network-online.target nss-lookup.target mysql.service mariadb.service mysqld.service docker.service

[Service]
Type=simple
StandardError=journal
ExecStart=/usr/local/bin/trojan web -p 81
ExecReload=/bin/kill -HUP $MAINPID
Restart=on-failure
RestartSec=3s

[Install]
WantedBy=multi-user.target
```

至此配置全部完成，重启全部容器后就可以实现最终效果了
  

参考文档
* [VPS 初体验（三）在 VPS 上快速搭建 trojan 服务](https://kiku.vip/2021/10/16/在%20VPS%20快速搭建%20trojan%20服务/)
* [VPS 初体验（四）trojan 和 Nginx 共用 443 端口](https://kiku.vip/2021/10/17/trojan%20和%20Nginx%20共用%20443%20端口/)
* [程小白](https://www.chengxiaobai.com/trouble-maker/trojan-shared-443-port-scheme)
* [Trojan多用户面板+宝塔+Docker](https://www.duojilu.com/archives/212)
[在docker中使用Nginx并实现反向代理](https://toyong.cn/2023/05/30/ed00.html)
