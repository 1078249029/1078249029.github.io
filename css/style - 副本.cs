﻿@charset "UTF-8";

/**
 * global variables and mixins
 */

/**
 * font family
 */

/**
 * 
 */

/* Mixins */

/**
 * bootstrap
 */

/*!
 * Bootstrap v3.3.7 (http://getbootstrap.com)
 * Copyright 2011-2016 Twitter, Inc.
 * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
 */

/*! normalize.css v3.0.3 | MIT License | github.com/necolas/normalize.css */

html {
  font-family: sans-serif;
  -ms-text-size-adjust: 100%;
  -webkit-text-size-adjust: 100%;
}

body {
  margin: 0;
}

article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
main,
menu,
nav,
section,
summary {
  display: block;
}

audio,
canvas,
progress,
video {
  display: inline-block;
  vertical-align: baseline;
}

audio:not([controls]) {
  display: none;
  height: 0;
}

[hidden],
template {
  display: none;
}

a {
  background-color: transparent;
}

a:active,
a:hover {
  outline: 0;
}

abbr[title] {
  border-bottom: 1px dotted;
}

b,
strong {
  font-weight: bold;
}

dfn {
  font-style: italic;
}

h1 {
  font-size: 2em;
  margin: 0.67em 0;
}

mark {
  background: #ff0;
  color: #000;
}

small {
  font-size: 80%;
}

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sup {
  top: -0.5em;
}

sub {
  bottom: -0.25em;
}

img {
  border: 0;
}

svg:not(:root) {
  overflow: hidden;
}

figure {
  margin: 1em 40px;
}

hr {
  -webkit-box-sizing: content-box;
  box-sizing: content-box;
  height: 0;
}

pre {
  overflow: auto;
}

code,
kbd,
pre,
samp {
  font-family: monospace,monospace;
  font-size: 1em;
}

button,
input,
optgroup,
select,
textarea {
  color: inherit;
  font: inherit;
  margin: 0;
}

button {
  overflow: visible;
}

button,
select {
  text-transform: none;
}

button,
html input[type="button"],
input[type="reset"],
input[type="submit"] {
  -webkit-appearance: button;
  cursor: pointer;
}

button[disabled],
html input[disabled] {
  cursor: default;
}

button::-moz-focus-inner,
input::-moz-focus-inner {
  border: 0;
  padding: 0;
}

input {
  line-height: normal;
}

input[type="checkbox"],
input[type="radio"] {
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
  padding: 0;
}

input[type="number"]::-webkit-inner-spin-button,
input[type="number"]::-webkit-outer-spin-button {
  height: auto;
}

input[type="search"] {
  -webkit-appearance: textfield;
  -webkit-box-sizing: content-box;
  box-sizing: content-box;
}

input[type="search"]::-webkit-search-cancel-button,
input[type="search"]::-webkit-search-decoration {
  -webkit-appearance: none;
}

fieldset {
  border: 1px solid #c0c0c0;
  margin: 0 2px;
  padding: 0.35em 0.625em 0.75em;
}

legend {
  border: 0;
  padding: 0;
}

textarea {
  overflow: auto;
}

optgroup {
  font-weight: bold;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

td,
th {
  padding: 0;
}

/*! Source: https://github.com/h5bp/html5-boilerplate/blob/master/src/css/main.css */

* {
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
}

*:before,
*:after {
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
}

html {
  font-size: 10px;
  -webkit-tap-highlight-color: transparent;
}

input,
button,
select,
textarea {
  font-family: inherit;
  font-size: inherit;
  line-height: inherit;
}

a {
  color: #2196f3;
  text-decoration: none;
}

a:hover,
a:focus {
  color: #0a6ebd;
  text-decoration: underline;
}

a:focus {
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px;
}

figure {
  margin: 0;
}

img {
  vertical-align: middle;
}

.img-responsive {
  display: block;
  max-width: 100%;
  height: auto;
}

.img-rounded {
  border-radius: 6px;
}

.img-thumbnail {
  padding: 4px;
  line-height: 1.57143;
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 4px;
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
  display: inline-block;
  max-width: 100%;
  height: auto;
}

.img-circle {
  border-radius: 50%;
}

hr {
  margin-top: 21px;
  margin-bottom: 21px;
  border: 0;
  border-top: 1px solid #eeeeee;
}

.sr-only {
  position: absolute;
  width: 1px;
  height: 1px;
  margin: -1px;
  padding: 0;
  overflow: hidden;
  clip: rect(0, 0, 0, 0);
  border: 0;
}

.sr-only-focusable:active,
.sr-only-focusable:focus {
  position: static;
  width: auto;
  height: auto;
  margin: 0;
  overflow: visible;
  clip: auto;
}

[role="button"] {
  cursor: pointer;
}

h1,
h2,
h3,
h4,
h5,
h6,
.h1,
.h2,
.h3,
.h4,
.h5,
.h6 {
  font-family: inherit;
  font-weight: 500;
  line-height: 1.1;
  color: inherit;
}

h1 small,
h1 .small,
h2 small,
h2 .small,
h3 small,
h3 .small,
h4 small,
h4 .small,
h5 small,
h5 .small,
h6 small,
h6 .small,
.h1 small,
.h1 .small,
.h2 small,
.h2 .small,
.h3 small,
.h3 .small,
.h4 small,
.h4 .small,
.h5 small,
.h5 .small,
.h6 small,
.h6 .small {
  font-weight: normal;
  line-height: 1;
  color: #777777;
}

h1,
.h1,
h2,
.h2,
h3,
.h3 {
  margin-top: 21px;
  margin-bottom: 10.5px;
}

h1 small,
h1 .small,
.h1 small,
.h1 .small,
h2 small,
h2 .small,
.h2 small,
.h2 .small,
h3 small,
h3 .small,
.h3 small,
.h3 .small {
  font-size: 65%;
}

h4,
.h4,
h5,
.h5,
h6,
.h6 {
  margin-top: 10.5px;
  margin-bottom: 10.5px;
}

h4 small,
h4 .small,
.h4 small,
.h4 .small,
h5 small,
h5 .small,
.h5 small,
.h5 .small,
h6 small,
h6 .small,
.h6 small,
.h6 .small {
  font-size: 75%;
}

h1,
.h1 {
  font-size: 30px;
}

h2,
.h2 {
  font-size: 26px;
}

h3,
.h3 {
  font-size: 22px;
}

h4,
.h4 {
  font-size: 18px;
}

h5,
.h5 {
  font-size: 14px;
}

h6,
.h6 {
  font-size: 12px;
}

p {
  margin: 0 0 10.5px;
}

.lead {
  margin-bottom: 21px;
  font-size: 16px;
  font-weight: 300;
  line-height: 1.4;
}

small,
.small {
  font-size: 85%;
}

mark,
.mark {
  background-color: #fcf8e3;
  padding: .2em;
}

.text-left {
  text-align: left;
}

.text-right {
  text-align: right;
}

.text-center {
  text-align: center;
}

.text-justify {
  text-align: justify;
}

.text-nowrap {
  white-space: nowrap;
}

.text-lowercase {
  text-transform: lowercase;
}

.text-uppercase,
.initialism {
  text-transform: uppercase;
}

.text-capitalize {
  text-transform: capitalize;
}

.text-muted {
  color: #777777 !important;
}

.text-primary {
  color: #2196f3;
}

a.text-primary:hover,
a.text-primary:focus {
  color: #0c7cd5;
}

.text-success {
  color: #3c763d;
}

a.text-success:hover,
a.text-success:focus {
  color: #2b542c;
}

.text-info {
  color: #31708f;
}

a.text-info:hover,
a.text-info:focus {
  color: #245269;
}

.text-warning {
  color: #8a6d3b;
}

a.text-warning:hover,
a.text-warning:focus {
  color: #66512c;
}

.text-danger {
  color: #a94442;
}

a.text-danger:hover,
a.text-danger:focus {
  color: #843534;
}

.bg-primary {
  color: #fff;
}

.bg-primary {
  background-color: #2196f3;
}

a.bg-primary:hover,
a.bg-primary:focus {
  background-color: #0c7cd5;
}

.bg-success {
  background-color: #dff0d8;
}

a.bg-success:hover,
a.bg-success:focus {
  background-color: #c1e2b3;
}

.bg-info {
  background-color: #d9edf7;
}

a.bg-info:hover,
a.bg-info:focus {
  background-color: #afd9ee;
}

.bg-warning {
  background-color: #fcf8e3;
}

a.bg-warning:hover,
a.bg-warning:focus {
  background-color: #f7ecb5;
}

.bg-danger {
  background-color: #f2dede;
}

a.bg-danger:hover,
a.bg-danger:focus {
  background-color: #e4b9b9;
}

.page-header {
  padding-bottom: 9.5px;
  margin: 42px 0 21px;
  border-bottom: 1px solid #eeeeee;
}

ul,
ol {
  margin-top: 0;
  margin-bottom: 10.5px;
}

ul ul,
ul ol,
ol ul,
ol ol {
  margin-bottom: 0;
}

.list-unstyled {
  padding-left: 0;
  list-style: none;
}

.list-inline {
  padding-left: 0;
  list-style: none;
  margin-left: -5px;
}

.list-inline > li {
  display: inline-block;
  padding-left: 5px;
  padding-right: 5px;
}

dl {
  margin-top: 0;
  margin-bottom: 21px;
}

dt,
dd {
  line-height: 1.57143;
}

dt {
  font-weight: bold;
}

dd {
  margin-left: 0;
}

.dl-horizontal dd:before,
.dl-horizontal dd:after {
  content: " ";
  display: table;
}

.dl-horizontal dd:after {
  clear: both;
}

abbr[title],
abbr[data-original-title] {
  cursor: help;
  border-bottom: 1px dotted #777777;
}

.initialism {
  font-size: 90%;
}

blockquote {
  padding: 10.5px 16px;
  margin: 0 0 21px;
  border: 1px dotted #eeeeee;
  border-left: 3px solid #eeeeee;
  background-color: #fbfbfb;
}

blockquote p:last-child,
blockquote ul:last-child,
blockquote ol:last-child {
  margin-bottom: 0;
}

blockquote footer,
blockquote small,
blockquote .small {
  display: block;
  font-size: 80%;
  line-height: 1.57143;
  color: #777777;
}

blockquote footer:before,
blockquote small:before,
blockquote .small:before {
  content: '\2014 \00A0';
}

.blockquote-reverse,
blockquote.pull-right {
  padding-right: 15px;
  padding-left: 0;
  border-right: 5px solid #eeeeee;
  border-left: 0;
  text-align: right;
}

.blockquote-reverse footer:before,
.blockquote-reverse small:before,
.blockquote-reverse .small:before,
blockquote.pull-right footer:before,
blockquote.pull-right small:before,
blockquote.pull-right .small:before {
  content: '';
}

.blockquote-reverse footer:after,
.blockquote-reverse small:after,
.blockquote-reverse .small:after,
blockquote.pull-right footer:after,
blockquote.pull-right small:after,
blockquote.pull-right .small:after {
  content: '\00A0 \2014';
}

address {
  margin-bottom: 21px;
  font-style: normal;
  line-height: 1.57143;
}

.container {
  margin-right: auto;
  margin-left: auto;
  padding-left: 15px;
  padding-right: 15px;
}

.container:before,
.container:after {
  content: " ";
  display: table;
}

.container:after {
  clear: both;
}

.container-fluid {
  margin-right: auto;
  margin-left: auto;
  padding-left: 15px;
  padding-right: 15px;
}

.container-fluid:before,
.container-fluid:after {
  content: " ";
  display: table;
}

.container-fluid:after {
  clear: both;
}

.row {
  margin-left: -15px;
  margin-right: -15px;
}

.row:before,
.row:after {
  content: " ";
  display: table;
}

.row:after {
  clear: both;
}

.col-xs-1,
.col-sm-1,
.col-md-1,
.col-lg-1,
.col-xs-2,
.col-sm-2,
.col-md-2,
.col-lg-2,
.col-xs-3,
.col-sm-3,
.col-md-3,
.col-lg-3,
.col-xs-4,
.col-sm-4,
.col-md-4,
.col-lg-4,
.col-xs-5,
.col-sm-5,
.col-md-5,
.col-lg-5,
.col-xs-6,
.col-sm-6,
.col-md-6,
.col-lg-6,
.col-xs-7,
.col-sm-7,
.col-md-7,
.col-lg-7,
.col-xs-8,
.col-sm-8,
.col-md-8,
.col-lg-8,
.col-xs-9,
.col-sm-9,
.col-md-9,
.col-lg-9,
.col-xs-10,
.col-sm-10,
.col-md-10,
.col-lg-10,
.col-xs-11,
.col-sm-11,
.col-md-11,
.col-lg-11,
.col-xs-12,
.col-sm-12,
.col-md-12,
.col-lg-12 {
  position: relative;
  min-height: 1px;
  padding-left: 15px;
  padding-right: 15px;
}

.col-xs-1,
.col-xs-2,
.col-xs-3,
.col-xs-4,
.col-xs-5,
.col-xs-6,
.col-xs-7,
.col-xs-8,
.col-xs-9,
.col-xs-10,
.col-xs-11,
.col-xs-12 {
  float: left;
}

.col-xs-1 {
  width: 8.33333%;
}

.col-xs-2 {
  width: 16.66667%;
}

.col-xs-3 {
  width: 25%;
}

.col-xs-4 {
  width: 33.33333%;
}

.col-xs-5 {
  width: 41.66667%;
}

.col-xs-6 {
  width: 50%;
}

.col-xs-7 {
  width: 58.33333%;
}

.col-xs-8 {
  width: 66.66667%;
}

.col-xs-9 {
  width: 75%;
}

.col-xs-10 {
  width: 83.33333%;
}

.col-xs-11 {
  width: 91.66667%;
}

.col-xs-12 {
  width: 100%;
}

.col-xs-pull-0 {
  right: auto;
}

.col-xs-pull-1 {
  right: 8.33333%;
}

.col-xs-pull-2 {
  right: 16.66667%;
}

.col-xs-pull-3 {
  right: 25%;
}

.col-xs-pull-4 {
  right: 33.33333%;
}

.col-xs-pull-5 {
  right: 41.66667%;
}

.col-xs-pull-6 {
  right: 50%;
}

.col-xs-pull-7 {
  right: 58.33333%;
}

.col-xs-pull-8 {
  right: 66.66667%;
}

.col-xs-pull-9 {
  right: 75%;
}

.col-xs-pull-10 {
  right: 83.33333%;
}

.col-xs-pull-11 {
  right: 91.66667%;
}

.col-xs-pull-12 {
  right: 100%;
}

.col-xs-push-0 {
  left: auto;
}

.col-xs-push-1 {
  left: 8.33333%;
}

.col-xs-push-2 {
  left: 16.66667%;
}

.col-xs-push-3 {
  left: 25%;
}

.col-xs-push-4 {
  left: 33.33333%;
}

.col-xs-push-5 {
  left: 41.66667%;
}

.col-xs-push-6 {
  left: 50%;
}

.col-xs-push-7 {
  left: 58.33333%;
}

.col-xs-push-8 {
  left: 66.66667%;
}

.col-xs-push-9 {
  left: 75%;
}

.col-xs-push-10 {
  left: 83.33333%;
}

.col-xs-push-11 {
  left: 91.66667%;
}

.col-xs-push-12 {
  left: 100%;
}

.col-xs-offset-0 {
  margin-left: 0%;
}

.col-xs-offset-1 {
  margin-left: 8.33333%;
}

.col-xs-offset-2 {
  margin-left: 16.66667%;
}

.col-xs-offset-3 {
  margin-left: 25%;
}

.col-xs-offset-4 {
  margin-left: 33.33333%;
}

.col-xs-offset-5 {
  margin-left: 41.66667%;
}

.col-xs-offset-6 {
  margin-left: 50%;
}

.col-xs-offset-7 {
  margin-left: 58.33333%;
}

.col-xs-offset-8 {
  margin-left: 66.66667%;
}

.col-xs-offset-9 {
  margin-left: 75%;
}

.col-xs-offset-10 {
  margin-left: 83.33333%;
}

.col-xs-offset-11 {
  margin-left: 91.66667%;
}

.col-xs-offset-12 {
  margin-left: 100%;
}

.btn {
  display: inline-block;
  margin-bottom: 0;
  font-weight: normal;
  text-align: center;
  vertical-align: middle;
  -ms-touch-action: manipulation;
  touch-action: manipulation;
  cursor: pointer;
  background-image: none;
  border: 1px solid transparent;
  white-space: nowrap;
  padding: 6px 12px;
  font-size: 14px;
  line-height: 1.57143;
  border-radius: 4px;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
}

.btn:focus,
.btn.focus,
.btn:active:focus,
.btn:active.focus,
.btn.active:focus,
.btn.active.focus {
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px;
}

.btn:hover,
.btn:focus,
.btn.focus {
  color: #333;
  text-decoration: none;
}

.btn:active,
.btn.active {
  outline: 0;
  background-image: none;
  -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
  box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
}

.btn.disabled,
.btn[disabled],
fieldset[disabled] .btn {
  cursor: not-allowed;
  opacity: 0.65;
  filter: alpha(opacity=65);
  -webkit-box-shadow: none;
  box-shadow: none;
}

a.btn.disabled,
fieldset[disabled] a.btn {
  pointer-events: none;
}

.btn-default {
  color: #333;
  background-color: #fff;
  border-color: #ccc;
}

.btn-default:focus,
.btn-default.focus {
  color: #333;
  background-color: #e6e6e6;
  border-color: #8c8c8c;
}

.btn-default:hover {
  color: #333;
  background-color: #e6e6e6;
  border-color: #adadad;
}

.btn-default:active,
.btn-default.active,
.open > .btn-default.dropdown-toggle {
  color: #333;
  background-color: #e6e6e6;
  border-color: #adadad;
}

.btn-default:active:hover,
.btn-default:active:focus,
.btn-default:active.focus,
.btn-default.active:hover,
.btn-default.active:focus,
.btn-default.active.focus,
.open > .btn-default.dropdown-toggle:hover,
.open > .btn-default.dropdown-toggle:focus,
.open > .btn-default.dropdown-toggle.focus {
  color: #333;
  background-color: #d4d4d4;
  border-color: #8c8c8c;
}

.btn-default:active,
.btn-default.active,
.open > .btn-default.dropdown-toggle {
  background-image: none;
}

.btn-default.disabled:hover,
.btn-default.disabled:focus,
.btn-default.disabled.focus,
.btn-default[disabled]:hover,
.btn-default[disabled]:focus,
.btn-default[disabled].focus,
fieldset[disabled] .btn-default:hover,
fieldset[disabled] .btn-default:focus,
fieldset[disabled] .btn-default.focus {
  background-color: #fff;
  border-color: #ccc;
}

.btn-default .badge {
  color: #fff;
  background-color: #333;
}

.btn-primary {
  color: #fff;
  background-color: #2196f3;
  border-color: #0d8aee;
}

.btn-primary:focus,
.btn-primary.focus {
  color: #fff;
  background-color: #0c7cd5;
  border-color: #064475;
}

.btn-primary:hover {
  color: #fff;
  background-color: #0c7cd5;
  border-color: #0a68b4;
}

.btn-primary:active,
.btn-primary.active,
.open > .btn-primary.dropdown-toggle {
  color: #fff;
  background-color: #0c7cd5;
  border-color: #0a68b4;
}

.btn-primary:active:hover,
.btn-primary:active:focus,
.btn-primary:active.focus,
.btn-primary.active:hover,
.btn-primary.active:focus,
.btn-primary.active.focus,
.open > .btn-primary.dropdown-toggle:hover,
.open > .btn-primary.dropdown-toggle:focus,
.open > .btn-primary.dropdown-toggle.focus {
  color: #fff;
  background-color: #0a68b4;
  border-color: #064475;
}

.btn-primary:active,
.btn-primary.active,
.open > .btn-primary.dropdown-toggle {
  background-image: none;
}

.btn-primary.disabled:hover,
.btn-primary.disabled:focus,
.btn-primary.disabled.focus,
.btn-primary[disabled]:hover,
.btn-primary[disabled]:focus,
.btn-primary[disabled].focus,
fieldset[disabled] .btn-primary:hover,
fieldset[disabled] .btn-primary:focus,
fieldset[disabled] .btn-primary.focus {
  background-color: #2196f3;
  border-color: #0d8aee;
}

.btn-primary .badge {
  color: #2196f3;
  background-color: #fff;
}

.btn-success {
  color: #fff;
  background-color: #5cb85c;
  border-color: #4cae4c;
}

.btn-success:focus,
.btn-success.focus {
  color: #fff;
  background-color: #449d44;
  border-color: #255625;
}

.btn-success:hover {
  color: #fff;
  background-color: #449d44;
  border-color: #398439;
}

.btn-success:active,
.btn-success.active,
.open > .btn-success.dropdown-toggle {
  color: #fff;
  background-color: #449d44;
  border-color: #398439;
}

.btn-success:active:hover,
.btn-success:active:focus,
.btn-success:active.focus,
.btn-success.active:hover,
.btn-success.active:focus,
.btn-success.active.focus,
.open > .btn-success.dropdown-toggle:hover,
.open > .btn-success.dropdown-toggle:focus,
.open > .btn-success.dropdown-toggle.focus {
  color: #fff;
  background-color: #398439;
  border-color: #255625;
}

.btn-success:active,
.btn-success.active,
.open > .btn-success.dropdown-toggle {
  background-image: none;
}

.btn-success.disabled:hover,
.btn-success.disabled:focus,
.btn-success.disabled.focus,
.btn-success[disabled]:hover,
.btn-success[disabled]:focus,
.btn-success[disabled].focus,
fieldset[disabled] .btn-success:hover,
fieldset[disabled] .btn-success:focus,
fieldset[disabled] .btn-success.focus {
  background-color: #5cb85c;
  border-color: #4cae4c;
}

.btn-success .badge {
  color: #5cb85c;
  background-color: #fff;
}

.btn-info {
  color: #fff;
  background-color: #56CCF2;
  border-color: #3ec5f0;
}

.btn-info:focus,
.btn-info.focus {
  color: #fff;
  background-color: #27beee;
  border-color: #0d7ea3;
}

.btn-info:hover {
  color: #fff;
  background-color: #27beee;
  border-color: #11aee0;
}

.btn-info:active,
.btn-info.active,
.open > .btn-info.dropdown-toggle {
  color: #fff;
  background-color: #27beee;
  border-color: #11aee0;
}

.btn-info:active:hover,
.btn-info:active:focus,
.btn-info:active.focus,
.btn-info.active:hover,
.btn-info.active:focus,
.btn-info.active.focus,
.open > .btn-info.dropdown-toggle:hover,
.open > .btn-info.dropdown-toggle:focus,
.open > .btn-info.dropdown-toggle.focus {
  color: #fff;
  background-color: #11aee0;
  border-color: #0d7ea3;
}

.btn-info:active,
.btn-info.active,
.open > .btn-info.dropdown-toggle {
  background-image: none;
}

.btn-info.disabled:hover,
.btn-info.disabled:focus,
.btn-info.disabled.focus,
.btn-info[disabled]:hover,
.btn-info[disabled]:focus,
.btn-info[disabled].focus,
fieldset[disabled] .btn-info:hover,
fieldset[disabled] .btn-info:focus,
fieldset[disabled] .btn-info.focus {
  background-color: #56CCF2;
  border-color: #3ec5f0;
}

.btn-info .badge {
  color: #56CCF2;
  background-color: #fff;
}

.btn-warning {
  color: #fff;
  background-color: #F09819;
  border-color: #e18b0f;
}

.btn-warning:focus,
.btn-warning.focus {
  color: #fff;
  background-color: #c97c0d;
  border-color: #694107;
}

.btn-warning:hover {
  color: #fff;
  background-color: #c97c0d;
  border-color: #a7670b;
}

.btn-warning:active,
.btn-warning.active,
.open > .btn-warning.dropdown-toggle {
  color: #fff;
  background-color: #c97c0d;
  border-color: #a7670b;
}

.btn-warning:active:hover,
.btn-warning:active:focus,
.btn-warning:active.focus,
.btn-warning.active:hover,
.btn-warning.active:focus,
.btn-warning.active.focus,
.open > .btn-warning.dropdown-toggle:hover,
.open > .btn-warning.dropdown-toggle:focus,
.open > .btn-warning.dropdown-toggle.focus {
  color: #fff;
  background-color: #a7670b;
  border-color: #694107;
}

.btn-warning:active,
.btn-warning.active,
.open > .btn-warning.dropdown-toggle {
  background-image: none;
}

.btn-warning.disabled:hover,
.btn-warning.disabled:focus,
.btn-warning.disabled.focus,
.btn-warning[disabled]:hover,
.btn-warning[disabled]:focus,
.btn-warning[disabled].focus,
fieldset[disabled] .btn-warning:hover,
fieldset[disabled] .btn-warning:focus,
fieldset[disabled] .btn-warning.focus {
  background-color: #F09819;
  border-color: #e18b0f;
}

.btn-warning .badge {
  color: #F09819;
  background-color: #fff;
}

.btn-danger {
  color: #fff;
  background-color: #FF512F;
  border-color: #ff3c16;
}

.btn-danger:focus,
.btn-danger.focus {
  color: #fff;
  background-color: #fb2900;
  border-color: #951800;
}

.btn-danger:hover {
  color: #fff;
  background-color: #fb2900;
  border-color: #d72300;
}

.btn-danger:active,
.btn-danger.active,
.open > .btn-danger.dropdown-toggle {
  color: #fff;
  background-color: #fb2900;
  border-color: #d72300;
}

.btn-danger:active:hover,
.btn-danger:active:focus,
.btn-danger:active.focus,
.btn-danger.active:hover,
.btn-danger.active:focus,
.btn-danger.active.focus,
.open > .btn-danger.dropdown-toggle:hover,
.open > .btn-danger.dropdown-toggle:focus,
.open > .btn-danger.dropdown-toggle.focus {
  color: #fff;
  background-color: #d72300;
  border-color: #951800;
}

.btn-danger:active,
.btn-danger.active,
.open > .btn-danger.dropdown-toggle {
  background-image: none;
}

.btn-danger.disabled:hover,
.btn-danger.disabled:focus,
.btn-danger.disabled.focus,
.btn-danger[disabled]:hover,
.btn-danger[disabled]:focus,
.btn-danger[disabled].focus,
fieldset[disabled] .btn-danger:hover,
fieldset[disabled] .btn-danger:focus,
fieldset[disabled] .btn-danger.focus {
  background-color: #FF512F;
  border-color: #ff3c16;
}

.btn-danger .badge {
  color: #FF512F;
  background-color: #fff;
}

.btn-link {
  color: #2196f3;
  font-weight: normal;
  border-radius: 0;
}

.btn-link,
.btn-link:active,
.btn-link.active,
.btn-link[disabled],
fieldset[disabled] .btn-link {
  background-color: transparent;
  -webkit-box-shadow: none;
  box-shadow: none;
}

.btn-link,
.btn-link:hover,
.btn-link:focus,
.btn-link:active {
  border-color: transparent;
}

.btn-link:hover,
.btn-link:focus {
  color: #0a6ebd;
  text-decoration: underline;
  background-color: transparent;
}

.btn-link[disabled]:hover,
.btn-link[disabled]:focus,
fieldset[disabled] .btn-link:hover,
fieldset[disabled] .btn-link:focus {
  color: #777777;
  text-decoration: none;
}

.btn-lg {
  padding: 10px 16px;
  font-size: 18px;
  line-height: 1.33333;
  border-radius: 6px;
}

.btn-sm {
  padding: 5px 10px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px;
}

.btn-xs {
  padding: 1px 5px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px;
}

.btn-block {
  display: block;
  width: 100%;
}

.btn-block + .btn-block {
  margin-top: 5px;
}

input[type="submit"].btn-block,
input[type="reset"].btn-block,
input[type="button"].btn-block {
  width: 100%;
}

.fade {
  opacity: 0;
  -webkit-transition: opacity 0.15s linear;
  transition: opacity 0.15s linear;
}

.fade.in {
  opacity: 1;
}

.collapse {
  display: none;
}

.collapse.in {
  display: block;
}

tr.collapse.in {
  display: table-row;
}

tbody.collapse.in {
  display: table-row-group;
}

.collapsing {
  position: relative;
  height: 0;
  overflow: hidden;
  -webkit-transition-property: height,visibility;
  transition-property: height,visibility;
  -webkit-transition-duration: 0.35s;
  transition-duration: 0.35s;
  -webkit-transition-timing-function: ease;
  transition-timing-function: ease;
}

.caret {
  display: inline-block;
  width: 0;
  height: 0;
  margin-left: 2px;
  vertical-align: middle;
  border-top: 4px dashed;
  border-top: 4px solid \9;
  border-right: 4px solid transparent;
  border-left: 4px solid transparent;
}

.dropup,
.dropdown {
  position: relative;
}

.dropdown-toggle:focus {
  outline: 0;
}

.dropdown-menu {
  position: absolute;
  top: 100%;
  left: 0;
  z-index: 1000;
  display: none;
  float: left;
  min-width: 160px;
  padding: 5px 0;
  margin: 2px 0 0;
  list-style: none;
  font-size: 14px;
  text-align: left;
  background-color: #fff;
  border: 1px solid #ccc;
  border: 1px solid rgba(0, 0, 0, 0.15);
  border-radius: 4px;
  -webkit-box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
  box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
  background-clip: padding-box;
}

.dropdown-menu.pull-right {
  right: 0;
  left: auto;
}

.dropdown-menu .divider {
  height: 1px;
  margin: 9.5px 0;
  overflow: hidden;
  background-color: #e5e5e5;
}

.dropdown-menu > li > a {
  display: block;
  padding: 3px 20px;
  clear: both;
  font-weight: normal;
  line-height: 1.57143;
  color: #333333;
  white-space: nowrap;
}

.dropdown-menu > li > a:hover,
.dropdown-menu > li > a:focus {
  text-decoration: none;
  color: #262626;
  background-color: #f5f5f5;
}

.dropdown-menu > .active > a,
.dropdown-menu > .active > a:hover,
.dropdown-menu > .active > a:focus {
  color: #fff;
  text-decoration: none;
  outline: 0;
  background-color: #2196f3;
}

.dropdown-menu > .disabled > a,
.dropdown-menu > .disabled > a:hover,
.dropdown-menu > .disabled > a:focus {
  color: #777777;
}

.dropdown-menu > .disabled > a:hover,
.dropdown-menu > .disabled > a:focus {
  text-decoration: none;
  background-color: transparent;
  background-image: none;
  filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
  cursor: not-allowed;
}

.open > .dropdown-menu {
  display: block;
}

.open > a {
  outline: 0;
}

.dropdown-menu-right {
  left: auto;
  right: 0;
}

.dropdown-menu-left {
  left: 0;
  right: auto;
}

.dropdown-header {
  display: block;
  padding: 3px 20px;
  font-size: 12px;
  line-height: 1.57143;
  color: #777777;
  white-space: nowrap;
}

.dropdown-backdrop {
  position: fixed;
  left: 0;
  right: 0;
  bottom: 0;
  top: 0;
  z-index: 990;
}

.pull-right > .dropdown-menu {
  right: 0;
  left: auto;
}

.dropup .caret,
.navbar-fixed-bottom .dropdown .caret {
  border-top: 0;
  border-bottom: 4px dashed;
  border-bottom: 4px solid \9;
  content: "";
}

.dropup .dropdown-menu,
.navbar-fixed-bottom .dropdown .dropdown-menu {
  top: auto;
  bottom: 100%;
  margin-bottom: 2px;
}

.input-group {
  position: relative;
  display: table;
  border-collapse: separate;
}

.input-group[class*="col-"] {
  float: none;
  padding-left: 0;
  padding-right: 0;
}

.input-group .form-control {
  position: relative;
  z-index: 2;
  float: left;
  width: 100%;
  margin-bottom: 0;
}

.input-group .form-control:focus {
  z-index: 3;
}

.input-group-addon,
.input-group-btn,
.input-group .form-control {
  display: table-cell;
}

.input-group-addon:not(:first-child):not(:last-child),
.input-group-btn:not(:first-child):not(:last-child),
.input-group .form-control:not(:first-child):not(:last-child) {
  border-radius: 0;
}

.input-group-addon,
.input-group-btn {
  width: 1%;
  white-space: nowrap;
  vertical-align: middle;
}

.input-group-addon {
  padding: 6px 12px;
  font-size: 14px;
  font-weight: normal;
  line-height: 1;
  color: #555555;
  text-align: center;
  background-color: #eeeeee;
  border: 1px solid #ccc;
  border-radius: 4px;
}

.input-group-addon.input-sm,
.input-group-sm > .input-group-addon,
.input-group-sm > .input-group-btn > .input-group-addon.btn {
  padding: 5px 10px;
  font-size: 12px;
  border-radius: 3px;
}

.input-group-addon.input-lg,
.input-group-lg > .input-group-addon,
.input-group-lg > .input-group-btn > .input-group-addon.btn {
  padding: 10px 16px;
  font-size: 18px;
  border-radius: 6px;
}

.input-group-addon input[type="radio"],
.input-group-addon input[type="checkbox"] {
  margin-top: 0;
}

.input-group .form-control:first-child,
.input-group-addon:first-child,
.input-group-btn:first-child > .btn,
.input-group-btn:first-child > .btn-group > .btn,
.input-group-btn:first-child > .dropdown-toggle,
.input-group-btn:last-child > .btn:not(:last-child):not(.dropdown-toggle),
.input-group-btn:last-child > .btn-group:not(:last-child) > .btn {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0;
}

.input-group-addon:first-child {
  border-right: 0;
}

.input-group .form-control:last-child,
.input-group-addon:last-child,
.input-group-btn:last-child > .btn,
.input-group-btn:last-child > .btn-group > .btn,
.input-group-btn:last-child > .dropdown-toggle,
.input-group-btn:first-child > .btn:not(:first-child),
.input-group-btn:first-child > .btn-group:not(:first-child) > .btn {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0;
}

.input-group-addon:last-child {
  border-left: 0;
}

.input-group-btn {
  position: relative;
  font-size: 0;
  white-space: nowrap;
}

.input-group-btn > .btn {
  position: relative;
}

.input-group-btn > .btn + .btn {
  margin-left: -1px;
}

.input-group-btn > .btn:hover,
.input-group-btn > .btn:focus,
.input-group-btn > .btn:active {
  z-index: 2;
}

.input-group-btn:first-child > .btn,
.input-group-btn:first-child > .btn-group {
  margin-right: -1px;
}

.input-group-btn:last-child > .btn,
.input-group-btn:last-child > .btn-group {
  z-index: 2;
  margin-left: -1px;
}

.nav {
  margin-bottom: 0;
  padding-left: 0;
  list-style: none;
}

.nav:before,
.nav:after {
  content: " ";
  display: table;
}

.nav:after {
  clear: both;
}

.nav > li {
  position: relative;
  display: block;
}

.nav > li > a {
  position: relative;
  display: block;
  padding: 10px 15px;
}

.nav > li > a:hover,
.nav > li > a:focus {
  text-decoration: none;
  background-color: #eeeeee;
}

.nav > li.disabled > a {
  color: #777777;
}

.nav > li.disabled > a:hover,
.nav > li.disabled > a:focus {
  color: #777777;
  text-decoration: none;
  background-color: transparent;
  cursor: not-allowed;
}

.nav .open > a,
.nav .open > a:hover,
.nav .open > a:focus {
  background-color: #eeeeee;
  border-color: #2196f3;
}

.nav .nav-divider {
  height: 1px;
  margin: 9.5px 0;
  overflow: hidden;
  background-color: #e5e5e5;
}

.nav > li > a > img {
  max-width: none;
}

.nav-tabs {
  border-bottom: 1px solid #f2f2f2;
}

.nav-tabs > li {
  float: left;
  margin-bottom: -1px;
}

.nav-tabs > li > a {
  margin-right: 2px;
  line-height: 1.57143;
  border: 1px solid transparent;
  border-radius: 4px 4px 0 0;
}

.nav-tabs > li > a:hover {
  border-color: #eeeeee #eeeeee #f2f2f2;
}

.nav-tabs > li.active > a,
.nav-tabs > li.active > a:hover,
.nav-tabs > li.active > a:focus {
  color: #555555;
  background-color: #fff;
  border: 1px solid #f2f2f2;
  border-bottom-color: transparent;
  cursor: default;
}

.nav-pills > li {
  float: left;
}

.nav-pills > li > a {
  border-radius: 4px;
}

.nav-pills > li + li {
  margin-left: 2px;
}

.nav-pills > li.active > a,
.nav-pills > li.active > a:hover,
.nav-pills > li.active > a:focus {
  color: #fff;
  background-color: #2196f3;
}

.nav-stacked > li {
  float: none;
}

.nav-stacked > li + li {
  margin-top: 2px;
  margin-left: 0;
}

.nav-justified,
.nav-tabs.nav-justified {
  width: 100%;
}

.nav-justified > li,
.nav-tabs.nav-justified > li {
  float: none;
}

.nav-justified > li > a,
.nav-tabs.nav-justified > li > a {
  text-align: center;
  margin-bottom: 5px;
}

.nav-justified > .dropdown .dropdown-menu {
  top: auto;
  left: auto;
}

.nav-tabs-justified,
.nav-tabs.nav-justified {
  border-bottom: 0;
}

.nav-tabs-justified > li > a,
.nav-tabs.nav-justified > li > a {
  margin-right: 0;
  border-radius: 4px;
}

.nav-tabs-justified > .active > a,
.nav-tabs.nav-justified > .active > a,
.nav-tabs-justified > .active > a:hover,
.nav-tabs.nav-justified > .active > a:hover,
.nav-tabs-justified > .active > a:focus,
.nav-tabs.nav-justified > .active > a:focus {
  border: 1px solid #f2f2f2;
}

.tab-content > .tab-pane {
  display: none;
}

.tab-content > .active {
  display: block;
}

.nav-tabs .dropdown-menu {
  margin-top: -1px;
  border-top-right-radius: 0;
  border-top-left-radius: 0;
}

.navbar {
  position: relative;
  min-height: 50px;
  margin-bottom: 21px;
  border: 1px solid transparent;
}

.navbar:before,
.navbar:after {
  content: " ";
  display: table;
}

.navbar:after {
  clear: both;
}

.navbar-header:before,
.navbar-header:after {
  content: " ";
  display: table;
}

.navbar-header:after {
  clear: both;
}

.navbar-collapse {
  overflow-x: visible;
  padding-right: 15px;
  padding-left: 15px;
  border-top: 1px solid transparent;
  -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1);
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1);
  -webkit-overflow-scrolling: touch;
}

.navbar-collapse:before,
.navbar-collapse:after {
  content: " ";
  display: table;
}

.navbar-collapse:after {
  clear: both;
}

.navbar-collapse.in {
  overflow-y: auto;
}

.navbar-fixed-top .navbar-collapse,
.navbar-fixed-bottom .navbar-collapse {
  max-height: 340px;
}

.container > .navbar-header,
.container > .navbar-collapse,
.container-fluid > .navbar-header,
.container-fluid > .navbar-collapse {
  margin-right: -15px;
  margin-left: -15px;
}

.navbar-static-top {
  z-index: 1000;
  border-width: 0 0 1px;
}

.navbar-fixed-top,
.navbar-fixed-bottom {
  position: fixed;
  right: 0;
  left: 0;
  z-index: 1030;
}

.navbar-fixed-top {
  top: 0;
  border-width: 0 0 1px;
}

.navbar-fixed-bottom {
  bottom: 0;
  margin-bottom: 0;
  border-width: 1px 0 0;
}

.navbar-brand {
  float: left;
  padding: 14.5px 15px;
  font-size: 18px;
  line-height: 21px;
  height: 50px;
}

.navbar-brand:hover,
.navbar-brand:focus {
  text-decoration: none;
}

.navbar-brand > img {
  display: block;
}

.navbar-toggle {
  position: relative;
  float: right;
  margin-right: 15px;
  padding: 10px 10px;
  margin-top: 8px;
  margin-bottom: 8px;
  background-color: transparent;
  background-image: none;
  border: 1px solid transparent;
  border-radius: 4px;
}

.navbar-toggle:focus {
  outline: 0;
}

.navbar-toggle .icon-bar {
  display: block;
  width: 22px;
  height: 2px;
  border-radius: 1px;
}

.navbar-toggle .icon-bar + .icon-bar {
  margin-top: 3px;
}

.navbar-nav {
  margin: 7.25px -15px;
}

.navbar-nav > li > a {
  padding-top: 10px;
  padding-bottom: 10px;
  line-height: 21px;
}

.navbar-form {
  margin-left: -15px;
  margin-right: -15px;
  padding: 10px 15px;
  border-top: 1px solid transparent;
  border-bottom: 1px solid transparent;
  -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1),0 1px 0 rgba(255, 255, 255, 0.1);
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1),0 1px 0 rgba(255, 255, 255, 0.1);
  margin-top: 7.5px;
  margin-bottom: 7.5px;
}

.navbar-nav > li > .dropdown-menu {
  margin-top: 0;
  border-top-right-radius: 0;
  border-top-left-radius: 0;
}

.navbar-fixed-bottom .navbar-nav > li > .dropdown-menu {
  margin-bottom: 0;
  border-top-right-radius: 4px;
  border-top-left-radius: 4px;
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0;
}

.navbar-btn {
  margin-top: 7.5px;
  margin-bottom: 7.5px;
}

.navbar-btn.btn-sm {
  margin-top: 10px;
  margin-bottom: 10px;
}

.navbar-btn.btn-xs {
  margin-top: 14px;
  margin-bottom: 14px;
}

.navbar-text {
  margin-top: 14.5px;
  margin-bottom: 14.5px;
}

.navbar-default {
  background-color: #f8f8f8;
  border-color: #e7e7e7;
}

.navbar-default .navbar-brand {
  color: #777;
}

.navbar-default .navbar-brand:hover,
.navbar-default .navbar-brand:focus {
  color: #5e5e5e;
  background-color: transparent;
}

.navbar-default .navbar-text {
  color: #777;
}

.navbar-default .navbar-nav > li > a {
  color: #777;
}

.navbar-default .navbar-nav > li > a:hover,
.navbar-default .navbar-nav > li > a:focus {
  color: #333;
  background-color: transparent;
}

.navbar-default .navbar-nav > .active > a,
.navbar-default .navbar-nav > .active > a:hover,
.navbar-default .navbar-nav > .active > a:focus {
  color: #555;
  background-color: #e7e7e7;
}

.navbar-default .navbar-nav > .disabled > a,
.navbar-default .navbar-nav > .disabled > a:hover,
.navbar-default .navbar-nav > .disabled > a:focus {
  color: #ccc;
  background-color: transparent;
}

.navbar-default .navbar-toggle {
  border-color: #ddd;
}

.navbar-default .navbar-toggle:hover,
.navbar-default .navbar-toggle:focus {
  background-color: #ddd;
}

.navbar-default .navbar-toggle .icon-bar {
  background-color: #888;
}

.navbar-default .navbar-collapse,
.navbar-default .navbar-form {
  border-color: #e7e7e7;
}

.navbar-default .navbar-nav > .open > a,
.navbar-default .navbar-nav > .open > a:hover,
.navbar-default .navbar-nav > .open > a:focus {
  background-color: #e7e7e7;
  color: #555;
}

.navbar-default .navbar-link {
  color: #777;
}

.navbar-default .navbar-link:hover {
  color: #333;
}

.navbar-default .btn-link {
  color: #777;
}

.navbar-default .btn-link:hover,
.navbar-default .btn-link:focus {
  color: #333;
}

.navbar-default .btn-link[disabled]:hover,
.navbar-default .btn-link[disabled]:focus,
fieldset[disabled] .navbar-default .btn-link:hover,
fieldset[disabled] .navbar-default .btn-link:focus {
  color: #ccc;
}

.navbar-inverse {
  background-color: #222;
  border-color: #090909;
}

.navbar-inverse .navbar-brand {
  color: #9d9d9d;
}

.navbar-inverse .navbar-brand:hover,
.navbar-inverse .navbar-brand:focus {
  color: #fff;
  background-color: transparent;
}

.navbar-inverse .navbar-text {
  color: #9d9d9d;
}

.navbar-inverse .navbar-nav > li > a {
  color: #9d9d9d;
}

.navbar-inverse .navbar-nav > li > a:hover,
.navbar-inverse .navbar-nav > li > a:focus {
  color: #fff;
  background-color: transparent;
}

.navbar-inverse .navbar-nav > .active > a,
.navbar-inverse .navbar-nav > .active > a:hover,
.navbar-inverse .navbar-nav > .active > a:focus {
  color: #fff;
  background-color: #090909;
}

.navbar-inverse .navbar-nav > .disabled > a,
.navbar-inverse .navbar-nav > .disabled > a:hover,
.navbar-inverse .navbar-nav > .disabled > a:focus {
  color: #444;
  background-color: transparent;
}

.navbar-inverse .navbar-toggle {
  border-color: #333;
}

.navbar-inverse .navbar-toggle:hover,
.navbar-inverse .navbar-toggle:focus {
  background-color: #333;
}

.navbar-inverse .navbar-toggle .icon-bar {
  background-color: #fff;
}

.navbar-inverse .navbar-collapse,
.navbar-inverse .navbar-form {
  border-color: #101010;
}

.navbar-inverse .navbar-nav > .open > a,
.navbar-inverse .navbar-nav > .open > a:hover,
.navbar-inverse .navbar-nav > .open > a:focus {
  background-color: #090909;
  color: #fff;
}

.navbar-inverse .navbar-link {
  color: #9d9d9d;
}

.navbar-inverse .navbar-link:hover {
  color: #fff;
}

.navbar-inverse .btn-link {
  color: #9d9d9d;
}

.navbar-inverse .btn-link:hover,
.navbar-inverse .btn-link:focus {
  color: #fff;
}

.navbar-inverse .btn-link[disabled]:hover,
.navbar-inverse .btn-link[disabled]:focus,
fieldset[disabled] .navbar-inverse .btn-link:hover,
fieldset[disabled] .navbar-inverse .btn-link:focus {
  color: #444;
}

.pager {
  padding-left: 0;
  margin: 21px 0;
  list-style: none;
  text-align: center;
}

.pager:before,
.pager:after {
  content: " ";
  display: table;
}

.pager:after {
  clear: both;
}

.pager li {
  display: inline;
}

.pager li > a,
.pager li > span {
  display: inline-block;
  padding: 5px 14px;
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 15px;
}

.pager li > a:hover,
.pager li > a:focus {
  text-decoration: none;
  background-color: #eeeeee;
}

.pager .next > a,
.pager .next > span {
  float: right;
}

.pager .previous > a,
.pager .previous > span {
  float: left;
}

.pager .disabled > a,
.pager .disabled > a:hover,
.pager .disabled > a:focus,
.pager .disabled > span {
  color: #777777;
  background-color: #fff;
  cursor: not-allowed;
}

.badge {
  display: inline-block;
  min-width: 10px;
  padding: 3px 7px;
  font-size: 12px;
  font-weight: bold;
  color: #fff;
  line-height: 1;
  vertical-align: middle;
  white-space: nowrap;
  text-align: center;
  background-color: #777777;
  border-radius: 10px;
}

.badge:empty {
  display: none;
}

.btn .badge {
  position: relative;
  top: -1px;
}

.btn-xs .badge,
.btn-group-xs > .btn .badge {
  top: 0;
  padding: 1px 5px;
}

.list-group-item.active > .badge,
.nav-pills > .active > a > .badge {
  color: #2196f3;
  background-color: #fff;
}

.list-group-item > .badge {
  float: right;
}

.list-group-item > .badge + .badge {
  margin-right: 5px;
}

.nav-pills > li > a > .badge {
  margin-left: 3px;
}

a.badge:hover,
a.badge:focus {
  color: #fff;
  text-decoration: none;
  cursor: pointer;
}

.thumbnail {
  display: block;
  padding: 4px;
  margin-bottom: 21px;
  line-height: 1.57143;
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 4px;
  -webkit-transition: border 0.2s ease-in-out;
  transition: border 0.2s ease-in-out;
}

.thumbnail > img,
.thumbnail a > img {
  display: block;
  max-width: 100%;
  height: auto;
  margin-left: auto;
  margin-right: auto;
}

.thumbnail .caption {
  padding: 9px;
  color: #333333;
}

a.thumbnail:hover,
a.thumbnail:focus,
a.thumbnail.active {
  border-color: #2196f3;
}

.media {
  margin-top: 15px;
}

.media:first-child {
  margin-top: 0;
}

.media,
.media-body {
  zoom: 1;
  overflow: hidden;
}

.media-body {
  width: 10000px;
}

.media-object {
  display: block;
}

.media-object.img-thumbnail {
  max-width: none;
}

.media-right,
.media > .pull-right {
  padding-left: 10px;
}

.media-left,
.media > .pull-left {
  padding-right: 10px;
}

.media-left,
.media-right,
.media-body {
  display: table-cell;
  vertical-align: top;
}

.media-middle {
  vertical-align: middle;
}

.media-middle .media-left,
.media-middle .media-right,
.media-middle .media-body {
  vertical-align: middle;
}

.media-bottom {
  vertical-align: bottom;
}

.media-bottom .media-left,
.media-bottom .media-right,
.media-bottom .media-body {
  vertical-align: bottom;
}

.media-heading {
  margin-top: 0;
  margin-bottom: 5px;
}

.media-list {
  padding-left: 0;
  list-style: none;
}

.embed-responsive {
  position: relative;
  display: block;
  height: 0;
  padding: 0;
  overflow: hidden;
}

.embed-responsive .embed-responsive-item,
.embed-responsive iframe,
.embed-responsive embed,
.embed-responsive object,
.embed-responsive video {
  position: absolute;
  top: 0;
  left: 0;
  bottom: 0;
  height: 100%;
  width: 100%;
  border: 0;
}

.embed-responsive-16by9 {
  padding-bottom: 56.25%;
}

.embed-responsive-4by3 {
  padding-bottom: 75%;
}

.well {
  min-height: 20px;
  padding: 19px;
  margin-bottom: 20px;
  background-color: #f5f5f5;
  border: 1px solid #e3e3e3;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05);
}

.well blockquote {
  border-color: #ddd;
  border-color: rgba(0, 0, 0, 0.15);
}

.well-lg {
  padding: 24px;
  border-radius: 6px;
}

.well-sm {
  padding: 9px;
  border-radius: 3px;
}

.close {
  float: right;
  font-size: 24px;
  line-height: 1;
  color: #000;
  text-shadow: 0 1px 0 #fff;
  opacity: 0.2;
  filter: alpha(opacity=20);
}

.close:hover,
.close:focus {
  color: #000;
  text-decoration: none;
  cursor: pointer;
  opacity: 0.5;
  filter: alpha(opacity=50);
}

button.close {
  padding: 0;
  cursor: pointer;
  background: transparent;
  border: 0;
  -webkit-appearance: none;
}

.modal-open {
  overflow: hidden;
}

.modal {
  display: none;
  overflow: hidden;
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1050;
  -webkit-overflow-scrolling: touch;
  outline: 0;
}

.modal.fade .modal-dialog {
  -webkit-transform: translate(0, -25%);
  -ms-transform: translate(0, -25%);
  transform: translate(0, -25%);
  -webkit-transition: -webkit-transform 0.3s ease-out;
  transition: -webkit-transform 0.3s ease-out;
  transition: transform 0.3s ease-out;
  transition: transform 0.3s ease-out,-webkit-transform 0.3s ease-out;
}

.modal.in .modal-dialog {
  -webkit-transform: translate(0, 0);
  -ms-transform: translate(0, 0);
  transform: translate(0, 0);
}

.modal-open .modal {
  overflow-x: hidden;
  overflow-y: auto;
}

.modal-dialog {
  position: relative;
  width: auto;
  margin: 10px;
}

.modal-content {
  position: relative;
  background-color: #fff;
  border-radius: 6px;
  -webkit-box-shadow: 0 3px 9px rgba(0, 0, 0, 0.05);
  box-shadow: 0 3px 9px rgba(0, 0, 0, 0.05);
  background-clip: padding-box;
  outline: 0;
}

.modal-backdrop {
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1040;
  background-color: #000;
}

.modal-backdrop.fade {
  opacity: 0;
  filter: alpha(opacity=0);
}

.modal-backdrop.in {
  opacity: 0.5;
  filter: alpha(opacity=50);
}

.modal-header {
  padding: 15px;
  border-bottom: 1px solid #e5e5e5;
}

.modal-header:before,
.modal-header:after {
  content: " ";
  display: table;
}

.modal-header:after {
  clear: both;
}

.modal-header .close {
  margin-top: -2px;
}

.modal-title {
  margin: 0;
  line-height: 1.57143;
}

.modal-body {
  position: relative;
  padding: 15px;
}

.modal-footer {
  padding: 15px;
  text-align: right;
  border-top: 1px solid #e5e5e5;
}

.modal-footer:before,
.modal-footer:after {
  content: " ";
  display: table;
}

.modal-footer:after {
  clear: both;
}

.modal-footer .btn + .btn {
  margin-left: 5px;
  margin-bottom: 0;
}

.modal-footer .btn-group .btn + .btn {
  margin-left: -1px;
}

.modal-footer .btn-block + .btn-block {
  margin-left: 0;
}

.modal-scrollbar-measure {
  position: absolute;
  top: -9999px;
  width: 50px;
  height: 50px;
  overflow: scroll;
}

.tooltip {
  position: absolute;
  z-index: 1070;
  display: block;
  font-family: "PingHei","PingFang SC",Helvetica Neue,"Work Sans","Hiragino Sans GB","Microsoft YaHei",SimSun,sans-serif;
  font-style: normal;
  font-weight: normal;
  letter-spacing: normal;
  line-break: auto;
  line-height: 1.57143;
  text-align: left;
  text-align: start;
  text-decoration: none;
  text-shadow: none;
  text-transform: none;
  white-space: normal;
  word-break: normal;
  word-spacing: normal;
  word-wrap: normal;
  font-size: 12px;
  opacity: 0;
  filter: alpha(opacity=0);
}

.tooltip.in {
  opacity: 0.9;
  filter: alpha(opacity=90);
}

.tooltip.top {
  margin-top: -3px;
  padding: 5px 0;
}

.tooltip.right {
  margin-left: 3px;
  padding: 0 5px;
}

.tooltip.bottom {
  margin-top: 3px;
  padding: 5px 0;
}

.tooltip.left {
  margin-left: -3px;
  padding: 0 5px;
}

.tooltip-inner {
  max-width: 200px;
  padding: 3px 8px;
  color: #fff;
  text-align: center;
  background-color: #000;
  border-radius: 4px;
}

.tooltip-arrow {
  position: absolute;
  width: 0;
  height: 0;
  border-color: transparent;
  border-style: solid;
}

.tooltip.top .tooltip-arrow {
  bottom: 0;
  left: 50%;
  margin-left: -5px;
  border-width: 5px 5px 0;
  border-top-color: #000;
}

.tooltip.top-left .tooltip-arrow {
  bottom: 0;
  right: 5px;
  margin-bottom: -5px;
  border-width: 5px 5px 0;
  border-top-color: #000;
}

.tooltip.top-right .tooltip-arrow {
  bottom: 0;
  left: 5px;
  margin-bottom: -5px;
  border-width: 5px 5px 0;
  border-top-color: #000;
}

.tooltip.right .tooltip-arrow {
  top: 50%;
  left: 0;
  margin-top: -5px;
  border-width: 5px 5px 5px 0;
  border-right-color: #000;
}

.tooltip.left .tooltip-arrow {
  top: 50%;
  right: 0;
  margin-top: -5px;
  border-width: 5px 0 5px 5px;
  border-left-color: #000;
}

.tooltip.bottom .tooltip-arrow {
  top: 0;
  left: 50%;
  margin-left: -5px;
  border-width: 0 5px 5px;
  border-bottom-color: #000;
}

.tooltip.bottom-left .tooltip-arrow {
  top: 0;
  right: 5px;
  margin-top: -5px;
  border-width: 0 5px 5px;
  border-bottom-color: #000;
}

.tooltip.bottom-right .tooltip-arrow {
  top: 0;
  left: 5px;
  margin-top: -5px;
  border-width: 0 5px 5px;
  border-bottom-color: #000;
}

.clearfix:before,
.clearfix:after {
  content: " ";
  display: table;
}

.clearfix:after {
  clear: both;
}

.center-block {
  display: block;
  margin-left: auto;
  margin-right: auto;
}

.pull-right {
  float: right !important;
}

.pull-left {
  float: left !important;
}

.hide {
  display: none !important;
}

.show {
  display: block !important;
}

.invisible {
  visibility: hidden;
}

.text-hide {
  font: 0/0 a;
  color: transparent;
  text-shadow: none;
  background-color: transparent;
  border: 0;
}

.hidden {
  display: none !important;
}

.affix {
  position: fixed;
}

@-ms-viewport {
  width: device-width;
}

.visible-xs {
  display: none !important;
}

.visible-sm {
  display: none !important;
}

.visible-md {
  display: none !important;
}

.visible-lg {
  display: none !important;
}

.visible-xs-block,
.visible-xs-inline,
.visible-xs-inline-block,
.visible-sm-block,
.visible-sm-inline,
.visible-sm-inline-block,
.visible-md-block,
.visible-md-inline,
.visible-md-inline-block,
.visible-lg-block,
.visible-lg-inline,
.visible-lg-inline-block {
  display: none !important;
}

.visible-print {
  display: none !important;
}

.visible-print-block {
  display: none !important;
}

.visible-print-inline {
  display: none !important;
}

.visible-print-inline-block {
  display: none !important;
}

/**
 * application
 */

/*!
 * IE10 viewport hack for Surface/desktop Windows 8 bug
 * Copyright 2014-2015 Twitter, Inc.
 * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
 */

/*
 * See the Getting Started docs for more information:
 * http://getbootstrap.com/getting-started/#support-ie10-width
 */

@-ms-viewport {
  width: device-width;
}

@-o-viewport {
  width: device-width;
}

@viewport {
  width: device-width;
}

/*
 * scrollbar
 */

::-webkit-scrollbar {
  width: 6px;
  height: 4px;
  background: transparent;
}

::-webkit-scrollbar-thumb {
  background: rgba(0, 0, 0, 0.15);
}

::-webkit-scrollbar-thumb:window-inactive {
  background: rgba(0, 0, 0, 0.1);
}

::-webkit-scrollbar-thumb:vertical {
  height: 4px;
  background: rgba(0, 0, 0, 0.15);
}

::-webkit-scrollbar-thumb:horizontal {
  width: 4px;
  background: rgba(0, 0, 0, 0.15);
}

::-webkit-scrollbar-thumb:vertical:hover {
  background-color: rgba(0, 0, 0, 0.3);
}

::-webkit-scrollbar-thumb:vertical:active {
  background-color: rgba(0, 0, 0, 0.5);
}

::-webkit-scrollbar-track {
  background: rgba(0, 0, 0, 0.1);
  -webkit-box-shadow: inset 0 0 3px rgba(0, 0, 0, 0.1);
  box-shadow: inset 0 0 3px rgba(0, 0, 0, 0.1);
}

::-webkit-scrollbar-track-piece {
  background: rgba(0, 0, 0, 0.15);
}

*,
*:before,
*:after {
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
}

html,
body {
  position: relative;
  overflow-x: hidden;
}

body {
  padding-right: 0 !important;
  font-family: "PingHei","PingFang SC",Helvetica Neue,"Work Sans","Hiragino Sans GB","Microsoft YaHei",SimSun,sans-serif;
  font-size: 14px;
  line-height: 1.57143;
  color: #333333;
  background-color: #fff;
}

a {
  color: #333333;
  text-decoration: none;
}

a:focus,
a:hover {
  color: #0a6ebd;
  text-decoration: none;
}

a.active {
  color: #0a6ebd;
}

.active > a {
  color: #0a6ebd;
}

input,
button,
select,
textarea,
.btn {
  outline: none !important;
}

input:focus,
input:hover,
input:active,
button:focus,
button:hover,
button:active,
select:focus,
select:hover,
select:active,
textarea:focus,
textarea:hover,
textarea:active,
.btn:focus,
.btn:hover,
.btn:active {
  outline: none !important;
}

/*------------------ Fluidity response ------------------------------*/

img,
canvas,
iframe,
video,
svg {
  max-width: 100%;
  height: auto;
}

/*------------------ clear ------------------------------*/

.clear {
  height: 0;
  font-size: 0;
  line-height: 0;
  overflow: hidden;
  clear: both;
}

.clearfix:before,
.clearfix:after {
  display: table;
  line-height: 0;
  content: "";
}

.clearfix:after {
  clear: both;
}

.clearfix {
  *zoom: 1;
}

/*other*/

.clickable {
  cursor: pointer;
}

.scrollable {
  overflow-x: hidden;
  overflow-y: auto;
}

/*transform*/

.transform-no {
  -ms-transform: none !important;
  -webkit-transform: none !important;
  transform: none !important;
}

/*----------------------------------------------------
 * color
 *---------------------------------------------------*/

.text-dark {
  color: #333 !important;
}

.text-grey {
  color: #999 !important;
}

/*text-white*/

.text-white {
  color: #fff !important;
}

.text-white a:hover,
.text-white a:hover i,
.text-white:hover {
  color: rgba(255, 255, 255, 0.8);
}

.text-white a.list-group-item.active i {
  color: #fff;
}

.text-white .accordion-list p {
  font-size: 12px;
  height: 84px;
  line-height: 21px;
  color: rgba(255, 255, 255, 0.8);
}

/*background-color*/

.bg-no {
  background: none !important;
}

.bg-alpha {
  background-color: transparent !important;
}

.bg-inverse,
.bg-inverse a {
  color: #fff;
}

.btn.bg-inverse:hover,
.btn.bg-inverse:focus,
.btn.bg-inverse.focus {
  color: rgba(255, 255, 255, 0.8);
}

.bg {
  background-color: #f6f6f6 !important;
}

/*----------------------------------------------------
 * z-index
 *---------------------------------------------------*/

.z-no {
  z-index: inherit;
}

.z1 {
  z-index: 1;
}

.z2 {
  z-index: 2;
}

.z3 {
  z-index: 3;
}

.z4 {
  z-index: 4;
}

.zmin {
  z-index: -1;
}

.zmax {
  z-index: 999;
}

/*----------------------------------------------------
 * margin
 *---------------------------------------------------*/

/* All */

.m {
  margin: 5px !important;
}

.m-no {
  margin: 0 !important;
}

.m-0x {
  margin: 10px !important;
}

.m-1x {
  margin: 15px !important;
}

.m-2x {
  margin: 20px !important;
}

.m-3x {
  margin: 30px !important;
}

.m-4x {
  margin: 60px !important;
}

.m-5x {
  margin: 100px !important;
}

/* Vertical */

.mv {
  margin-top: 5px !important;
  margin-bottom: 5px !important;
}

.mv-no {
  margin-top: 0 !important;
  margin-bottom: 0 !important;
}

.mv-0x {
  margin-top: 10px !important;
  margin-bottom: 10px !important;
}

.mv-1x {
  margin-top: 15px !important;
  margin-bottom: 15px !important;
}

.mv-2x {
  margin-top: 20px !important;
  margin-bottom: 20px !important;
}

.mv-3x {
  margin-top: 30px !important;
  margin-bottom: 30px !important;
}

.mv-4x {
  margin-top: 60px !important;
  margin-bottom: 60px !important;
}

.mv-5x {
  margin-top: 100px !important;
  margin-bottom: 100px !important;
}

/* Horizontal */

.mh {
  margin-left: 5px !important;
  margin-right: 5px !important;
}

.mh-no {
  margin-left: 0 !important;
  margin-right: 0 !important;
}

.mh-0x {
  margin-left: 10px !important;
  margin-right: 10px !important;
}

.mh-1x {
  margin-left: 15px !important;
  margin-right: 15px !important;
}

.mh-2x {
  margin-left: 20px !important;
  margin-right: 20px !important;
}

.mh-3x {
  margin-left: 30px !important;
  margin-right: 30px !important;
}

.mh-4x {
  margin-left: 60px !important;
  margin-right: 60px !important;
}

.mh-5x {
  margin-left: 100px !important;
  margin-right: 100px !important;
}

/* margin Top */

.mt {
  margin-top: 5px !important;
}

.mt-no {
  margin-top: 0 !important;
}

.mt-0x {
  margin-top: 10px !important;
}

.mt-1x {
  margin-top: 15px !important;
}

.mt-2x {
  margin-top: 20px !important;
}

.mt-3x {
  margin-top: 30px !important;
}

.mt-4x {
  margin-top: 60px !important;
}

.mt-5x {
  margin-top: 100px !important;
}

/* margin Bottom */

.mb {
  margin-bottom: 5px !important;
}

.mb-no {
  margin-bottom: 0 !important;
}

.mb-0x {
  margin-bottom: 10px !important;
}

.mb-1x {
  margin-bottom: 15px !important;
}

.mb-2x {
  margin-bottom: 20px !important;
}

.mb-3x {
  margin-bottom: 30px !important;
}

.mb-4x {
  margin-bottom: 60px !important;
}

.mb-5x {
  margin-bottom: 100px !important;
}

/* margin left */

.ml {
  margin-left: 5px !important;
}

.ml-no {
  margin-left: 0 !important;
}

.ml-0x {
  margin-left: 10px !important;
}

.ml-1x {
  margin-left: 15px !important;
}

.ml-2x {
  margin-left: 20px !important;
}

.ml-3x {
  margin-left: 30px !important;
}

.ml-4x {
  margin-left: 60px !important;
}

.ml-5x {
  margin-left: 100px !important;
}

/* margin right */

.mr {
  margin-right: 5px !important;
}

.mr-no {
  margin-right: 0 !important;
}

.mr-0x {
  margin-right: 10px !important;
}

.mr-1x {
  margin-right: 15px !important;
}

.mr-2x {
  margin-right: 20px !important;
}

.mr-3x {
  margin-right: 30px !important;
}

.mr-4x {
  margin-right: 60px !important;
}

.mr-5x {
  margin-right: 100px !important;
}

/*----------------------------------------------------
 * padding
 *---------------------------------------------------*/

/* All */

.p {
  padding: 5px !important;
}

.p-no {
  padding: 0 !important;
}

.p-0x {
  padding: 10px !important;
}

.p-1x {
  padding: 15px !important;
}

.p-2x {
  padding: 20px !important;
}

.p-3x {
  padding: 30px !important;
}

.p-4x {
  padding: 60px !important;
}

.p-5x {
  padding: 100px !important;
}

/* Vertical */

.pv {
  padding-top: 5px !important;
  padding-bottom: 5px !important;
}

.pv-no {
  padding-top: 0 !important;
  padding-bottom: 0 !important;
}

.pv-0x {
  padding-top: 10px !important;
  padding-bottom: 10px !important;
}

.pv-1x {
  padding-top: 15px !important;
  padding-bottom: 15px !important;
}

.pv-2x {
  padding-top: 20px !important;
  padding-bottom: 20px !important;
}

.pv-3x {
  padding-top: 30px !important;
  padding-bottom: 30px !important;
}

.pv-4x {
  padding-top: 60px !important;
  padding-bottom: 60px !important;
}

.pv-5x {
  padding-top: 100px !important;
  padding-bottom: 100px !important;
}

/* Horizontal */

.ph {
  padding-left: 5px !important;
  padding-right: 5px !important;
}

.ph-no {
  padding-left: 0 !important;
  padding-right: 0 !important;
}

.ph-0x {
  padding-left: 10px !important;
  padding-right: 10px !important;
}

.ph-1x {
  padding-left: 15px !important;
  padding-right: 15px !important;
}

.ph-2x {
  padding-left: 20px !important;
  padding-right: 20px !important;
}

.ph-3x {
  padding-left: 30px !important;
  padding-right: 30px !important;
}

.ph-4x {
  padding-left: 60px !important;
  padding-right: 60px !important;
}

.ph-5x {
  padding-left: 100px !important;
  padding-right: 100px !important;
}

/* padding Top */

.pt {
  padding-top: 5px !important;
}

.pt-no {
  padding-top: 0 !important;
}

.pt-0x {
  padding-top: 10px !important;
}

.pt-1x {
  padding-top: 15px !important;
}

.pt-2x {
  padding-top: 20px !important;
}

.pt-3x {
  padding-top: 30px !important;
}

.pt-4x {
  padding-top: 60px !important;
}

.pt-5x {
  padding-top: 100px !important;
}

/* padding Bottom */

.pb {
  padding-bottom: 5px !important;
}

.pb-no {
  padding-bottom: 0 !important;
}

.pb-0x {
  padding-bottom: 10px !important;
}

.pb-1x {
  padding-bottom: 15px !important;
}

.pb-2x {
  padding-bottom: 20px !important;
}

.pb-3x {
  padding-bottom: 30px !important;
}

.pb-4x {
  padding-bottom: 60px !important;
}

.pb-5x {
  padding-bottom: 100px !important;
}

/* padding left */

.pl {
  padding-left: 5px !important;
}

.pl-no {
  padding-left: 0 !important;
}

.pl-0x {
  padding-left: 10px !important;
}

.pl-1x {
  padding-left: 15px !important;
}

.pl-2x {
  padding-left: 20px !important;
}

.pl-3x {
  padding-left: 30px !important;
}

.pl-4x {
  padding-left: 60px !important;
}

.pl-5x {
  padding-left: 100px !important;
}

/* padding right */

.pr {
  padding-right: 5px !important;
}

.pr-no {
  padding-right: 0 !important;
}

.pr-0x {
  padding-right: 10px !important;
}

.pr-1x {
  padding-right: 15px !important;
}

.pr-2x {
  padding-right: 20px !important;
}

.pr-3x {
  padding-right: 30px !important;
}

.pr-4x {
  padding-right: 60px !important;
}

.pr-5x {
  padding-right: 100px !important;
}

/*----------------------------------------------------
 * border
 *---------------------------------------------------*/

.b {
  border: 1px solid #ddd;
}

.b-no {
  border: none !important;
}

/*----------------------------------------------------
 * border-radius
 *---------------------------------------------------*/

/*----------------------css border-radius----------------*/

.r-rounded {
  border-radius: 2em !important;
  padding-left: 1em;
  padding-right: 1em;
  overflow: hidden;
}

.r-circle {
  border-radius: 50% !important;
  overflow: hidden;
}

.r-no {
  border-radius: 0 !important;
}

/*----------------------------------------------------
 * width and height
 *---------------------------------------------------*/

.w-auto {
  width: auto !important;
}

.w-full,
.w-full img {
  width: 100% !important;
  max-width: 100% !important;
}

/*----------------------------------------------------
 * text
 *---------------------------------------------------*/

.lh-2x {
  line-height: 2.0;
}

/*-----------------   css text    --------------------*/

.text-break {
  word-break: break-all !important;
  word-wrap: break-word !important;
}

.text-undecorate {
  text-decoration: none !important;
}

.text-underline {
  text-decoration: underline !important;
}

.text-through {
  text-decoration: line-through !important;
}

.text-sub {
  vertical-align: sub !important;
}

.text-super {
  vertical-align: super !important;
}

.text-indent,
.text-indent p,
.text-indent div {
  text-indent: 2em;
}

/*text wrap*/

.text-nowrap {
  /*display: block;*/
  max-width: 100%;
  overflow: hidden !important;
  text-overflow: ellipsis !important;
  white-space: nowrap !important;
  word-wrap: normal !important;
  -moz-binding: url("ellipsis.xml");
}

.text-nowrap-1x {
  display: -webkit-box;
  overflow: hidden;
  text-overflow: ellipsis;
  -webkit-box-orient: vertical;
  -webkit-line-clamp: 1;
  -webkit-box-flex: 1;
  line-height: 24px;
  height: 24px;
  word-break: break-all !important;
  word-wrap: break-word !important;
}

.text-nowrap-2x {
  display: -webkit-box;
  overflow: hidden;
  text-overflow: ellipsis;
  -webkit-box-orient: vertical;
  -webkit-line-clamp: 2;
  line-height: 24px;
  height: 48px;
  word-break: break-all !important;
  word-wrap: break-word !important;
}

.text-nowrap-3x {
  display: -webkit-box;
  overflow: hidden;
  text-overflow: ellipsis;
  -webkit-box-orient: vertical;
  -webkit-line-clamp: 3;
  line-height: 24px;
  height: 72px;
  word-break: break-all !important;
  word-wrap: break-word !important;
}

.text-nowrap-4x {
  display: -webkit-box;
  overflow: hidden;
  text-overflow: ellipsis;
  -webkit-box-orient: vertical;
  -webkit-line-clamp: 4;
  line-height: 24px;
  height: 96px;
  word-break: break-all !important;
  word-wrap: break-word !important;
}

.text-nowrap-5x {
  display: -webkit-box;
  overflow: hidden;
  text-overflow: ellipsis;
  -webkit-box-orient: vertical;
  -webkit-line-clamp: 5;
  line-height: 24px;
  height: 120px;
  word-break: break-all !important;
  word-wrap: break-word !important;
}

/*----------------------------------------------------
 * thumb
 *---------------------------------------------------*/

.thumb {
  width: 16px;
  display: inline-block;
  overflow: hidden;
}

.thumb-xs {
  width: 32px;
  display: inline-block;
  overflow: hidden;
}

.thumb-sm {
  width: 48px;
  display: inline-block;
  overflow: hidden;
}

.thumb-md {
  width: 64px;
  display: inline-block;
  overflow: hidden;
}

.thumb-lg {
  width: 96px;
  display: inline-block;
  overflow: hidden;
}

.thumb-xl {
  width: 128px;
  display: inline-block;
  overflow: hidden;
}

.thumb-wrapper {
  padding: 2px;
  border: 1px solid #dbe2e7;
}

.thumb img,
.thumb-0x img,
.thumb-1x img,
.thumb-2x img,
.thumb-3x img,
.thumb-4x img,
.thumb-5x img,
.thumb-6x img,
.thumb-btn img {
  height: auto;
  max-width: 100%;
  vertical-align: middle;
}

/*----------------------------------------------------
 * img hover style
 *---------------------------------------------------*/

/*img gray*/

img.img-gray,
.img-gray img {
  -webkit-filter: grayscale(100%);
  -moz-filter: grayscale(100%);
  -ms-filter: grayscale(100%);
  -o-filter: grayscale(100%);
  filter: grayscale(100%);
  -webkit-filter: gray;
  filter: gray;
}

img.img-gray:hover,
.img-gray:hover img {
  -webkit-filter: grayscale(0);
  -moz-filter: grayscale(0);
  -ms-filter: grayscale(0);
  -o-filter: grayscale(0);
  filter: grayscale(0);
}
/*

/*img-rotate*/

img.img-rotate,
.img-rotate img {
  -webkit-transition: -webkit-transform 0.3s ease;
  transition: -webkit-transform 0.3s ease;
  transition: transform 0.3s ease;
  transition: transform 0.3s ease,-webkit-transform 0.3s ease;
}

img.img-rotate:hover,
.img-rotate:hover img {
  transform: rotate(360deg);
  -ms-transform: rotate(360deg);
  /* IE 9 */
  -moz-transform: rotate(360deg);
  /* Firefox */
  -webkit-transform: rotate(360deg);
  /* Safari and Chrome */
  -o-transform: rotate(360deg);
}



/*img-burn*/

img.img-burn,
.img-burn img {
  position: relative;
  -webkit-transition: all 0.8s ease-in-out;
  transition: all 0.8s ease-in-out;
}

img.img-burn:hover,
.img-burn:hover img {
  -webkit-transform: scale(1.2) rotate(2deg);
  -ms-transform: scale(1.2) rotate(2deg);
  transform: scale(1.2) rotate(2deg);
}

*/

/*hover-up*/

img.hover-up,
.hover-up img {
  position: relative;
  top: 0;
  -webkit-transition: top .3s ease-out;
  transition: top .3s ease-out;
}

img.hover-up:hover,
.hover-up:hover img {
  top: -6px;
}

/*Button components*/

.text-active,
.active > .text,
.active > .auto .text,
.collapsed > .text,
.collapsed > .auto .text {
  display: none !important;
}

.active > .text-active,
.active > .auto .text-active,
.collapsed > .text-active,
.collapsed > .auto .text-active {
  display: inline-block !important;
}

/*Button components end here*/

/**
 * paper
 */

.shadow-no {
  -webkit-box-shadow: none;
  box-shadow: none;
}

.shadow,
.hover-shadow:hover {
  -webkit-box-shadow: 0 1px 2px rgba(0, 0, 0, 0.05);
  box-shadow: 0 1px 2px rgba(0, 0, 0, 0.05);
}

/*radio*/

.radio {
  margin-left: 20px;
}

.radio label {
  display: inline-block;
  position: relative;
  padding-left: 5px;
}

.radio label:before {
  content: "";
  display: inline-block;
  position: absolute;
  width: 17px;
  height: 17px;
  left: 0;
  margin-left: -20px;
  border: 1px solid #cccccc;
  border-radius: 50%;
  background-color: #fff;
  -webkit-transition: border 0.15s ease-in-out;
  transition: border 0.15s ease-in-out;
}

.radio label:after {
  display: inline-block;
  position: absolute;
  content: " ";
  width: 11px;
  height: 11px;
  left: 3px;
  top: 3px;
  margin-left: -20px;
  border-radius: 50%;
  background-color: #555555;
  -webkit-transform: scale(0, 0);
  -ms-transform: scale(0, 0);
  transform: scale(0, 0);
  -webkit-transition: -webkit-transform 0.1s cubic-bezier(0.8, -0.33, 0.2, 1.33);
  transition: -webkit-transform 0.1s cubic-bezier(0.8, -0.33, 0.2, 1.33);
  transition: transform 0.1s cubic-bezier(0.8, -0.33, 0.2, 1.33);
  transition: transform 0.1s cubic-bezier(0.8, -0.33, 0.2, 1.33),-webkit-transform 0.1s cubic-bezier(0.8, -0.33, 0.2, 1.33);
}

.radio input[type=radio] {
  display: none;
}

.radio input[type=radio]:checked + label:after {
  -webkit-transform: scale(1, 1);
  -ms-transform: scale(1, 1);
  transform: scale(1, 1);
}

.radio input[type=radio]:disabled + label {
  opacity: 0.65;
}

.radio input[type=radio]:disabled + label:before {
  cursor: not-allowed;
}

.hover-grow {
  -webkit-transition: all .2s linear;
  transition: all .2s linear;
}

.hover-grow:hover {
  -webkit-transform: translate3d(0, -2px, 0);
  transform: translate3d(0, -2px, 0);
}

fieldset {
  padding: 0;
  margin: 0;
  border: 0;
  min-width: 0;
}

legend {
  display: block;
  width: 100%;
  padding: 0;
  margin-bottom: 21px;
  font-size: 21px;
  line-height: inherit;
  color: #333333;
  border: 0;
  border-bottom: 1px solid #e5e5e5;
}

label {
  display: inline-block;
  max-width: 100%;
  margin-bottom: 5px;
  font-weight: bold;
}

input[type="search"] {
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
}

input[type="radio"],
input[type="checkbox"] {
  margin: 4px 0 0;
  margin-top: 1px \9;
  line-height: normal;
}

input[type="file"] {
  display: block;
}

input[type="range"] {
  display: block;
  width: 100%;
}

select[multiple],
select[size] {
  height: auto;
}

input[type="file"]:focus,
input[type="radio"]:focus,
input[type="checkbox"]:focus {
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px;
}

output {
  display: block;
  padding-top: 7px;
  font-size: 14px;
  line-height: 1.57143;
  color: #555555;
}

.form-control {
  display: block;
  width: 100%;
  height: 35px;
  padding: 6px 12px;
  font-size: 14px;
  line-height: 1.57143;
  color: #555555;
  background-color: #fff;
  background-image: none;
  border: 1px solid #ccc;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  -webkit-transition: border-color ease-in-out 0.15s,box-shadow ease-in-out 0.15s;
  -webkit-transition: border-color ease-in-out 0.15s,-webkit-box-shadow ease-in-out 0.15s;
  transition: border-color ease-in-out 0.15s,-webkit-box-shadow ease-in-out 0.15s;
  transition: border-color ease-in-out 0.15s,box-shadow ease-in-out 0.15s;
  transition: border-color ease-in-out 0.15s,box-shadow ease-in-out 0.15s,-webkit-box-shadow ease-in-out 0.15s;
}

.form-control:focus {
  border-color: #66afe9;
  outline: 0;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075),0 0 8px rgba(102, 175, 233, 0.6);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075),0 0 8px rgba(102, 175, 233, 0.6);
}

.form-control::-moz-placeholder {
  color: #999;
  opacity: 1;
}

.form-control:-ms-input-placeholder {
  color: #999;
}

.form-control::-webkit-input-placeholder {
  color: #999;
}

.form-control::-ms-expand {
  border: 0;
  background-color: transparent;
}

.form-control[disabled],
.form-control[readonly],
fieldset[disabled] .form-control {
  background-color: #eeeeee;
  opacity: 1;
}

.form-control[disabled],
fieldset[disabled] .form-control {
  cursor: not-allowed;
}

textarea.form-control {
  height: auto;
}

input[type="search"] {
  -webkit-appearance: none;
}

/*
 * Component: list
 * ----------------
 */

.list-disc {
  list-style: disc !important;
}

.list-alpha {
  list-style: upper-alpha !important;
}

.list-decimal {
  list-style: decimal !important;
}

.list-outside {
  list-style-position: outside !important;
}

.list-inside {
  list-style-position: inside !important;
}

.list-square {
  list-style: none;
}

.list-square li:before {
  color: #ccc;
  content: "▪";
  font-size: 12px;
  margin-right: 6px;
  -webkit-transition: 0.2s ease;
  transition: 0.2s ease;
}

.list-circle-num,
.list-square-num {
  counter-reset: list1;
}

.list-circle-num > li,
.list-square-num > li {
  list-style: none outside none;
  margin-bottom: 13px;
}

.list-circle-num > li:before {
  counter-increment: list1;
  content: counter(list1) "";
  width: 24px;
  height: 24px;
  text-align: center;
  border-radius: 12px;
  font-size: 15px;
  border-width: 1px;
  border-style: solid;
  margin: 0 16px 0 0;
  display: inline-block;
  vertical-align: middle;
}

.list-square-num > li:before {
  counter-increment: list1;
  content: counter(list1) "";
  width: 24px;
  height: 24px;
  text-align: center;
  border-radius: 5px;
  font-size: 15px;
  border-width: 1px;
  border-style: solid;
  margin: 0 16px 0 0;
  display: inline-block;
  vertical-align: middle;
}

.list-circle-num > li > ol,
.list-square-num > li > ol {
  counter-reset: list2;
}

.list-circle-num > li > ol > li,
.list-square-num > li > ol > li {
  margin-bottom: 13px;
}

.list-circle-num > li > ol > li:before {
  counter-increment: list2;
  content: counter(list1) "." counter(list2) "";
  width: 24px;
  height: 24px;
  text-align: center;
  border-radius: 12px;
  font-size: 15px;
  border-width: 1px;
  border-style: solid;
  margin: 0 16px 0 0;
  display: inline-block;
  vertical-align: middle;
}

.list-square-num > li > ol > li:before {
  counter-increment: list2;
  content: counter(list1) "." counter(list2) "";
  width: 24px;
  height: 24px;
  text-align: center;
  border-radius: 5px;
  font-size: 15px;
  border-width: 1px;
  border-style: solid;
  margin: 0 16px 0 0;
  display: inline-block;
  vertical-align: middle;
}

.list-circle-num[class*="list-full"] > li::before,
.list-square-num[class*="list-full"] > li::before {
  background: #de4a32;
  color: #ffffff;
}

.label {
  display: inline-block;
  padding: .3em .6em;
  font-size: 75%;
  font-weight: bold;
  line-height: 1;
  color: #777777;
  text-align: center;
  white-space: nowrap;
  vertical-align: baseline;
  border-radius: .25em;
}

.label:empty {
  display: none;
}

.btn .label {
  position: relative;
  top: -1px;
}

a.label:hover,
a.label:focus {
  color: #333333;
  text-decoration: none;
  cursor: pointer;
}

.label-default {
  background-color: #eeeeee;
}

.label-default[href]:hover,
.label-default[href]:focus {
  background-color: #d5d5d5;
}

.label-primary {
  background-color: #2196f3;
  color: #fff;
}

.label-primary[href]:hover,
.label-primary[href]:focus {
  background-color: #0c7cd5;
}

.label-success {
  background-color: #5cb85c;
  color: #fff;
}

.label-success[href]:hover,
.label-success[href]:focus {
  background-color: #449d44;
}

.label-info {
  background-color: #56CCF2;
  color: #fff;
}

.label-info[href]:hover,
.label-info[href]:focus {
  background-color: #27beee;
}

.label-warning {
  background-color: #F09819;
  color: #fff;
}

.label-warning[href]:hover,
.label-warning[href]:focus {
  background-color: #c97c0d;
}

.label-danger {
  background-color: #FF512F;
  color: #fff;
}

.label-danger[href]:hover,
.label-danger[href]:focus {
  background-color: #fb2900;
}

.panel {
  margin-bottom: 21px;
  background-color: #fff;
  border: 1px solid #f2f2f2;
}

.panel .article-title {
  display: -webkit-box;
  overflow: hidden;
  text-overflow: ellipsis;
  -webkit-box-orient: vertical;
  -webkit-line-clamp: 2;
  font-size: 18px;
  line-height: 32px;
  height: 64px;
  word-break: break-all !important;
  word-wrap: break-word !important;
}

.panel-body {
  padding: 15px;
}

.panel-body:before,
.panel-body:after {
  content: " ";
  display: table;
}

.panel-body:after {
  clear: both;
}

.panel-heading {
  padding: 10px 15px;
  border-bottom: 1px solid #f2f2f2;
}

.panel-heading > .dropdown .dropdown-toggle {
  color: inherit;
}

.panel-title {
  margin-top: 0;
  margin-bottom: 0;
  font-size: 16px;
  color: inherit;
}

.panel-title > a,
.panel-title > small,
.panel-title > .small,
.panel-title > small > a,
.panel-title > .small > a {
  color: inherit;
  text-decoration: none;
}

.panel-footer {
  padding: 10px 15px;
  border-top: 1px solid #f2f2f2;
  border-bottom-right-radius: 3px;
  border-bottom-left-radius: 3px;
}

/**
 * panel-group-base
 */

.panel.b-no {
  border: 0;
  margin-bottom: 0;
}

.panel.b-no .panel-heading,
.panel.b-no .panel-body,
.panel.b-no .panel-footer {
  border: 0;
  padding-left: 0;
  padding-right: 0;
}

/* Badger*/

.panel-badger {
  position: relative;
}

.panel-badger:after {
  content: "";
  position: absolute;
  top: 0;
  width: 0;
  height: 0;
  border-width: 4px;
  border-style: solid;
  border-color: #777777 transparent transparent #777777;
}

.panel-badger:hover:after {
  border-color: #2196f3 transparent transparent #2196f3;
}

.badger-danger:after {
  border-color: #FF512F transparent transparent #FF512F;
}

.badger-warning:after {
  border-color: #F09819 transparent transparent #F09819;
}

.badger-success:after {
  border-color: #5cb85c transparent transparent #5cb85c;
}

.badger-info:after {
  border-color: #56CCF2 transparent transparent #56CCF2;
}

.badger-primary:after {
  border-color: #2196f3 transparent transparent #2196f3;
}

/* bg shortcodes */

.bg-gradient-info span,
.bg-gradient-info:before {
  background: #56CCF2;
  background: -webkit-linear-gradient(left, #56CCF2 0%, #2F80ED 80%, #2F80ED 100%);
  background: -webkit-gradient(linear, left top, right top, from(#56CCF2), color-stop(80%, #2F80ED), to(#2F80ED));
  background: linear-gradient(to right, #56CCF2 0%, #2F80ED 80%, #2F80ED 100%);
}

.bg-gradient-primary span,
.bg-gradient-primary:before {
  background: #396afc;
  background: -webkit-linear-gradient(left, #396afc 0%, #2948ff 80%, #2948ff 100%);
  background: -webkit-gradient(linear, left top, right top, from(#396afc), color-stop(80%, #2948ff), to(#2948ff));
  background: linear-gradient(to right, #396afc 0%, #2948ff 80%, #2948ff 100%);
}

.bg-gradient-success span,
.bg-gradient-success:before {
  background: #44ea76;
  background: -webkit-linear-gradient(left, #44ea76 0%, #39fad7 80%, #39fad7 100%);
  background: -webkit-gradient(linear, left top, right top, from(#44ea76), color-stop(80%, #39fad7), to(#39fad7));
  background: linear-gradient(to right, #44ea76 0%, #39fad7 80%, #39fad7 100%);
}

.bg-gradient-warning span,
.bg-gradient-warning:before {
  background: #FF512F;
  background: -webkit-linear-gradient(left, #FF512F 0%, #F09819 80%, #F09819 100%);
  background: -webkit-gradient(linear, left top, right top, from(#FF512F), color-stop(80%, #F09819), to(#F09819));
  background: linear-gradient(to right, #FF512F 0%, #F09819 80%, #F09819 100%);
}

.bg-gradient-danger span,
.bg-gradient-danger:before {
  background: #FF512F;
  background: -webkit-linear-gradient(left, #FF512F 0%, #DD2476 80%, #DD2476 100%);
  background: -webkit-gradient(linear, left top, right top, from(#FF512F), color-stop(80%, #DD2476), to(#DD2476));
  background: linear-gradient(to right, #FF512F 0%, #DD2476 80%, #DD2476 100%);
}

/* Button fancy */

.btn-fancy {
  display: inline-block;
  font-size: 17px;
  letter-spacing: 0.03em;
  text-transform: uppercase;
  color: #ffffff;
  position: relative;
}

.btn-fancy:before {
  content: '';
  display: inline-block;
  height: 40px;
  position: absolute;
  bottom: -5px;
  left: 30px;
  right: 30px;
  z-index: -1;
  -webkit-filter: blur(20px) brightness(0.95);
  filter: blur(20px) brightness(0.95);
  -webkit-transform-style: preserve-3d;
  transform-style: preserve-3d;
  -webkit-transition: all 0.3s ease-out;
  transition: all 0.3s ease-out;
}

.btn-fancy i {
  margin-top: -1px;
  margin-right: 20px;
  font-size: 1.265em;
  vertical-align: middle;
}

.btn-fancy span {
  display: inline-block;
  padding: 18px 60px;
  border-radius: 50em;
  position: relative;
  z-index: 2;
  will-change: transform,filter;
  -webkit-transform-style: preserve-3d;
  transform-style: preserve-3d;
  -webkit-transition: all 0.3s ease-out;
  transition: all 0.3s ease-out;
}

.btn-fancy:focus,
.btn-fancy:active {
  color: #ffffff;
}

.btn-fancy:hover {
  color: #ffffff;
}

.btn-fancy:hover span {
  -webkit-filter: brightness(1.05) contrast(1.05);
  filter: brightness(1.05) contrast(1.05);
  -webkit-transform: scale(0.95);
  -ms-transform: scale(0.95);
  transform: scale(0.95);
}

.btn-fancy:hover:before {
  bottom: 0;
  -webkit-filter: blur(10px) brightness(0.95);
  filter: blur(10px) brightness(0.95);
}

.btn-fancy.pop-onhover:before {
  opacity: 0;
  bottom: 10px;
}

.btn-fancy.pop-onhover:hover:before {
  bottom: -7px;
  opacity: 1;
  -webkit-filter: blur(20px);
  filter: blur(20px);
}

.btn-fancy.pop-onhover:hover span {
  -webkit-transform: scale(1.04);
  -ms-transform: scale(1.04);
  transform: scale(1.04);
}

.btn-fancy.pop-onhover:hover:active span {
  -webkit-filter: brightness(1) contrast(1);
  filter: brightness(1) contrast(1);
  -webkit-transform: scale(1);
  -ms-transform: scale(1);
  transform: scale(1);
  -webkit-transition: all 0.15s ease-out;
  transition: all 0.15s ease-out;
}

.btn-fancy.pop-onhover:hover:active:before {
  bottom: 0;
  -webkit-filter: blur(10px) brightness(0.95);
  filter: blur(10px) brightness(0.95);
  -webkit-transition: all 0.2s ease-out;
  transition: all 0.2s ease-out;
}

/*
 * Component: table
 * css like github
 * ----------------
 */

table {
  border: 1px solid #f2f2f2;
}

table > thead > tr > th,
table > thead > tr > td,
table > tbody > tr > th,
table > tbody > tr > td,
table > tfoot > tr > th,
table > tfoot > tr > td {
  border: 1px solid #f2f2f2;
}

table > tbody > tr:nth-of-type(odd) {
  background-color: #f8f8f8;
}

table > tbody > tr:hover {
  background-color: #fbfbfb;
}

table {
  padding: 0;
  width: 100%;
  max-width: 100%;
  margin: 10px 0;
}

table > thead > tr > th,
table > thead > tr > td,
table > tbody > tr > th,
table > tbody > tr > td,
table > tfoot > tr > th,
table > tfoot > tr > td {
  padding: 6px 13px;
}

table > tbody + tbody {
  border-top: 2px solid #f2f2f2;
}

table table {
  background-color: #fff;
}

.modal button.close {
  position: absolute;
  right: 10px;
  top: 10px;
  z-index: 99;
}

.modal-small .modal-dialog {
  width: 480px;
}

@font-face {
  font-family: "icon";
  src: url("iconfont.eot?t=1525101408939");
  /* IE9*/
  src: url("iconfont.eot?t=1525101408939#iefix") format("embedded-opentype"),url("data:application/x-font-woff;charset=utf-8;base64,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") format("woff"),url("iconfont.ttf?t=1525101408939") format("truetype"),url("iconfont.svg?t=1525101408939#icon") format("svg");
}

.icon {
  display: inline-block;
  font: normal normal normal 14px/1 icon;
  font-size: inherit;
  text-rendering: auto;
  -webkit-font-smoothing: antialiased;
  -webkit-text-stroke-width: 0.2px;
  -moz-osx-font-smoothing: grayscale;
}

.icon-diandian:before {
  content: "\e63a";
}

.icon-huaban:before {
  content: "\e63c";
}

.icon-code-fork:before {
  content: "\e67a";
}

.icon-more:before {
  content: "\e6c0";
}

.icon-zhihu:before {
  content: "\e6d1";
}

.icon-linkedin:before {
  content: "\e724";
}

.icon-eye-fill:before {
  content: "\e64f";
}

.icon-stackexchange:before {
  content: "\e8b2";
}

.icon-tag:before {
  content: "\e6a3";
}

.icon-starfish:before {
  content: "\e62e";
}

.icon-home:before {
  content: "\e660";
}

.icon-search:before {
  content: "\e61c";
}

.icon-project:before {
  content: "\e63e";
}

.icon-dialog:before {
  content: "\e613";
}

.icon-twitter:before {
  content: "\ec9c";
}

.icon-github:before {
  content: "\e70a";
}

.icon-time:before {
  content: "\e669";
}

.icon-voice:before {
  content: "\e65a";
}

.icon-google:before {
  content: "\e601";
}

.icon-weibo:before {
  content: "\e64b";
}

.icon-segmentfault:before {
  content: "\e610";
}

.icon-star-fill:before {
  content: "\e630";
}

.icon-phone:before {
  content: "\e68a";
}

.icon-cup-fill:before {
  content: "\e614";
}

.icon-jiaju:before {
  content: "\e671";
}

.icon-qzone:before {
  content: "\e603";
}

.icon-home-fill:before {
  content: "\e617";
}

.icon-clock:before {
  content: "\e618";
}

.icon-file:before {
  content: "\e66f";
}

.icon-comment:before {
  content: "\e61a";
}

.icon-cup:before {
  content: "\e62c";
}

.icon-share:before {
  content: "\e66a";
}

.icon-star-half:before {
  content: "\e62f";
}

.icon-star:before {
  content: "\e619";
}

.icon-tencent-weibo:before {
  content: "\e602";
}

.icon-book:before {
  content: "\e79d";
}

.icon-bitbucket:before {
  content: "\e64e";
}

.icon-facebook:before {
  content: "\e6e3";
}

.icon-email:before {
  content: "\e667";
}

.icon-zcool:before {
  content: "\e60c";
}

.icon-social-media:before {
  content: "\e68b";
}

.icon-douban:before {
  content: "\e60f";
}

.icon-coding:before {
  content: "\e600";
}

.icon-github-fill:before {
  content: "\e71d";
}

.icon-qq:before {
  content: "\e611";
}

.icon-shu-fill:before {
  content: "\e615";
}

.icon-pinterest:before {
  content: "\e697";
}

.icon-tags:before {
  content: "\e6c4";
}

.icon-bill:before {
  content: "\e61b";
}

.icon-shu:before {
  content: "\e616";
}

.icon-book-shelf:before {
  content: "\e60d";
}

.icon-target:before {
  content: "\e695";
}

.icon-profile:before {
  content: "\e6e2";
}

.icon-alipay:before {
  content: "\e938";
}

.icon-skype:before {
  content: "\e604";
}

.icon-juejin:before {
  content: "\e605";
}

.icon-code:before {
  content: "\e73f";
}

.icon-list:before {
  content: "\e61e";
}

.icon-map-marker:before {
  content: "\e609";
}

.icon-stackoverflow:before {
  content: "\e606";
}

.icon-hourglass:before {
  content: "\e60e";
}

.icon-behance:before {
  content: "\e67b";
}

.icon-folder-open:before {
  content: "\e6b4";
}

.icon-folder:before {
  content: "\e60a";
}

.icon-menu:before {
  content: "\e607";
}

.icon-users:before {
  content: "\e60b";
}

.icon-eye:before {
  content: "\e657";
}

.icon-wechat:before {
  content: "\e65e";
}

.icon-number:before {
  content: "\e658";
}

.icon-gitlab:before {
  content: "\e67c";
}

.icon-rss:before {
  content: "\e63d";
}

.icon-archives:before {
  content: "\e62d";
}

.icon-68design:before {
  content: "\e608";
}

.icon-dribble:before {
  content: "\e982";
}

.icon-wepay:before {
  content: "\e629";
}

.icon-youdao-note:before {
  content: "\e8a6";
}

.icon-book-fill:before {
  content: "\e659";
}

.icon-hezuo:before {
  content: "\e6e5";
}

.icon-link:before {
  content: "\e635";
}

.icon-archives-fill:before {
  content: "\e694";
}

.icon-anchor:before {
  content: "\e858";
}

.icon-angle-down:before {
  content: "\e85e";
}

.icon-angle-left:before {
  content: "\e85f";
}

.icon-angle-up:before {
  content: "\e860";
}

.icon-angle-right:before {
  content: "\e862";
}

.icon-calendar:before {
  content: "\e895";
}

.icon-calendar-check:before {
  content: "\e896";
}

.icon-calendar-minus:before {
  content: "\e897";
}

.icon-calendar-plus:before {
  content: "\e899";
}

.icon-calendar-times:before {
  content: "\e89a";
}

.icon-close:before {
  content: "\e8c4";
}

.icon-delicious:before {
  content: "\e8e2";
}

.icon-plus:before {
  content: "\e99d";
}

.icon-gg:before {
  content: "\e6fd";
}

.icon-friendship:before {
  content: "\e612";
}

.icon-gitee:before {
  content: "\e61d";
}

pre .comment {
  color: #8e908c;
}

pre .variable,
pre .attribute,
pre .tag,
pre .regexp,
pre .ruby .constant,
pre .xml .tag .title,
pre .xml .pi,
pre .xml .doctype,
pre .html .doctype,
pre .css .id,
pre .css .class,
pre .css .pseudo {
  color: #c82829;
}

pre .number,
pre .preprocessor,
pre .built_in,
pre .literal,
pre .params,
pre .constant {
  color: #f5871f;
}

pre .ruby .class .title,
pre .css .rules .attribute {
  color: #718c00;
}

pre .string,
pre .value,
pre .inheritance,
pre .header,
pre .ruby .symbol,
pre .xml .cdata {
  color: #718c00;
}

pre .title,
pre .css .hexcolor {
  color: #3e999f;
}

pre .function,
pre .python .decorator,
pre .python .title,
pre .ruby .function .title,
pre .ruby .title .keyword,
pre .perl .sub,
pre .javascript .title,
pre .js .title,
pre .coffeescript .title {
  color: #4271ae;
}

pre .keyword,
pre .javascript .function,
pre .js .function {
  color: #8959a8;
}

pre,
.highlight {
  background: #fafafa;
  margin: 10px 0;
  padding: 15px 10px;
  overflow: auto;
  font-size: 13px;
  color: #4d4d4c;
  line-height: 1.5;
}

.highlight .gutter pre,
.gist .gist-file .gist-data .line-numbers {
  color: #666;
}

code {
  text-shadow: 0 1px #fff;
  padding: 0.2em 0.4em;
  margin: 0 0.3em;
  color: #555;
  background: #eee;
  border-radius: 3px;
  font-size: 85%;
}

pre code {
  background: none;
  text-shadow: none;
  padding: 0;
}

.highlight {
  position: relative;
  padding: 32px 10px 0 10px;
  border-radius: 4px;
}

.highlight:before {
  display: block;
  content: ' ';
  height: 32px;
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
  background-color: #f6f6f6;
  padding: 0 10px;
  border-top-left-radius: 4px;
  border-top-right-radius: 4px;
}

.highlight:after {
  content: " ";
  position: absolute;
  border-radius: 50%;
  background: #fc625d;
  width: 10px;
  height: 10px;
  top: 0;
  left: 15px;
  margin-top: 11px;
  -webkit-box-shadow: 20px 0 #fdbc40,40px 0 #35cd4b;
  box-shadow: 20px 0 #fdbc40,40px 0 #35cd4b;
}

.highlight pre {
  border: none;
  margin: 0;
}

.highlight table {
  position: relative;
  border: none;
  width: 100%;
  margin: 0;
  padding: 0;
}

.highlight tr {
  border: none;
}

.highlight td,
.highlight th {
  border: none;
  padding: 0;
}

.highlight td.code,
.highlight th.code {
  width: 100% !important;
}

.highlight figcaption {
  font-size: 0.85em;
  color: #8e908c;
  line-height: 1em;
  margin-bottom: 1em;
}

.highlight figcaption a {
  float: right;
}

.highlight .line {
  height: 24px;
  line-height: 24px;
}

.highlight .gutter pre {
  text-align: right;
  padding-right: 0;
  padding-left: 0;
  color: #ccc;
}

/*
 * Sidebar
 */

/* Hide for mobile, show later */

.header {
  background-color: #fbfbfb;
}

.sidebar {
  background-color: #fdfdfd;
}

.sidebar .slimContent {
  padding: 20px;
}

.main {
  position: relative;
  min-height: 100vh;
  padding: 15px;
}

.main:before,
.main:after {
  content: " ";
  display: table;
}

.main:after {
  clear: both;
}

.footer {
  padding: 20px;
  background-color: #fbfbfb;
}

/*
 * main-center
 */

body.main-center .sidebar {
  left: auto;
  right: 0;
  border-left: 1px solid #f6f6f6;
  border-right: 0;
}

/*
 * main-left
 */

body.main-left .header {
  left: auto;
  right: 0;
  border-left: 1px solid #f6f6f6;
  border-right: 0;
}

body.main-left .sidebar {
  left: auto;
  right: 0;
  border-left: 1px solid #f6f6f6;
  border-right: 0;
}

body.main-left .footer {
  left: auto;
  right: 0;
}

/*
 * main-right
 */

body.no-sidebar .sidebar {
  display: none !important;
}

/**
 * Sidebar navigation
 */

.main-nav {
  float: none !important;
}

.main-nav > li {
  display: block;
  width: 100%;
  position: relative;
}

.main-nav > li > a {
  color: #555555;
}

.main-nav > li .menu-title {
  margin-left: 15px;
}

.main-nav > .active a,
.main-nav > .active a:hover,
.main-nav > .active a:focus {
  color: #333333;
  background: #f4f4f4;
}

/**
 * profile-block
 */

.profile-block {
  padding: 20px 15px 10px 15px;
}

#avatar {
  width: 64px;
  height: 64px;
  display: inline-block;
}

#avatar img {
  width: 100%;
  max-height: 100%;
  height: auto !important;
}

#name {
  font-size: 18px;
  margin-top: 10px;
  margin-bottom: 0;
}

#title {
  font-size: 13px;
  margin-top: 5px;
  margin-bottom: 5px;
}

/**
 * search
 */

.sidebar-form {
  border-radius: 3px;
  border: 1px solid #eee;
  margin: 0 15px 15px 15px;
}

.sidebar-form input[type="text"],
.sidebar-form .btn {
  -webkit-box-shadow: none;
  box-shadow: none;
  background-color: transparent;
  border: 1px solid transparent;
  height: 32px;
}

.sidebar-form input[type="text"]:focus,
.sidebar-form .btn:focus {
  outline: none;
}

.sidebar-form input[type="text"] {
  color: #666;
  border-top-left-radius: 2px;
  border-top-right-radius: 0;
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 2px;
}

.sidebar-form input[type="text"]:focus,
.sidebar-form input[type="text"]:focus + .input-group-btn .btn {
  background-color: #fff;
  color: #666;
}

.sidebar-form .btn {
  color: #999;
  border-top-left-radius: 0;
  border-top-right-radius: 2px;
  border-bottom-right-radius: 2px;
  border-bottom-left-radius: 0;
}

.header {
  /**
 * navbar
 */
}

.header .navbar-collapse {
  padding-left: 0;
  padding-right: 0;
}

.header .navbar-collapse .navbar-nav {
  margin: 0;
}

.header .navbar-toggle .icon-bar {
  background-color: #2196f3;
}

/*
 * Main content
 */

.main .pager {
  text-align: left;
  margin: 10px 0;
}

.main .pager .disabled {
  cursor: not-allowed;
}

.main .pager > a,
.main .pager > .page-number {
  line-height: 32px;
  /* float: left; */
}

.main .pager a {
  color: #666;
  border: 0;
  line-height: 32px;
  padding: 0;
}

.main .pager a:link,
.main .pager a:visited {
  background-color: transparent;
}

.main .pager a:hover {
  color: #0a6ebd;
  background-color: transparent;
}

.main .pager .prev {
  margin-right: 10px;
}

.main .pager .page-number.current {
  color: #2196f3;
}

.main .pager .page-number + .page-number {
  margin-left: 10px;
}

.main .pager .page-number + .next {
  margin-left: 10px;
}

.main .total-article {
  margin: 10px 0;
  line-height: 32px;
  color: #999;
}

.main .page-header {
  margin-top: 0;
}

.main .article-list article {
  border-bottom: 1px solid #f2f2f2;
}

.main .article-list article:last-child {
  border-bottom: 0;
}

.main .article-meta {
  font-size: 13px;
  color: #999;
}

.main .article-meta a {
  color: #999;
}

.main .article-meta a:hover {
  color: #0a6ebd;
  text-decoration: none;
}

.main .article-meta span + span {
  margin-left: 10px;
}

.main .content {
  min-height: 85vh;
}

.main.has-sticky .content {
  margin-bottom: 70px;
}

#comments .gitment-footer-container,
#comments .gitment-footer-project-link {
  display: none !important;
}

.panel .label,
.widget .label {
  font-weight: normal;
}

.widget:before,
.widget:after {
  content: " ";
  display: table;
}

.widget:after {
  clear: both;
}

.widget .widget-title {
  font-size: 18px;
  color: #000;
}

.widget time {
  color: #999;
  font-size: 12px;
  text-transform: uppercase;
}

.widget p {
  margin-bottom: 0;
}

.widget ul {
  margin-left: 0;
  padding-left: 0;
  list-style: none;
}

.widget .category-link {
  color: #0a6ebd;
}

.category-list-count,
.tag-list-count,
.archive-list-count {
  padding-left: 5px;
  color: #999;
  font-size: 0.85em;
}

.category-list-count:before,
.tag-list-count:before,
.archive-list-count:before {
  content: "(";
}

.category-list-count:after,
.tag-list-count:after,
.archive-list-count:after {
  content: ")";
}

.category-list,
.archive-list,
.tag-list {
  line-height: 1.75;
}

.category-list li:before,
.archive-list li:before,
.tag-list li:before {
  color: #ccc;
  content: "▪";
  font-size: 12px;
  margin-right: 6px;
  -webkit-transition: 0.2s ease;
  transition: 0.2s ease;
}

.category-list-child {
  padding-left: 15px;
}

.recent-post-list li + li {
  margin-top: 15px;
}

.recent-post-list li .item-thumb,
.recent-post-list li .item-inner {
  display: table-cell;
  vertical-align: middle;
}

.recent-post-list li .item-thumb {
  opacity: 1;
  padding-right: 10px;
  -webkit-transition: all 0.2s ease;
  transition: all 0.2s ease;
}

.recent-post-list li .item-thumb .thumb {
  width: 50px;
  height: 50px;
  display: block;
  position: relative;
  overflow: hidden;
}

.recent-post-list li .item-thumb .thumb span {
  width: 100%;
  height: 100%;
  display: block;
}

.recent-post-list li .item-thumb .thumb .thumb-image {
  position: absolute;
  background-size: cover;
  background-position: center;
}

.recent-post-list li .item-thumb .thumb .thumb-none {
  background-image: url("../images/thumb-default.png");
  background-size: 100% 100%;
}

.recent-post-list li:hover .item-thumb {
  opacity: 0.8;
}

.sidebar-toc.collapse {
  display: none !important;
}

.sidebar-toc.in {
  display: block !important;
}

.tagcloud a {
  display: inline-block;
  margin-bottom: 0.2em;
  padding: .3em .6em;
  font-size: 75% !important;
  line-height: 1;
  background-color: #eee;
  text-align: center;
  white-space: nowrap;
  vertical-align: baseline;
  border-radius: .25em;
}

.bar .pager .next > a,
.bar .pager .next > span {
  float: none;
}

.bar.bar-footer {
  position: relative;
  background-color: #fff;
  bottom: -15px;
}

.bar.bar-footer:before {
  content: '';
  position: absolute;
  width: -webkit-calc(100% + 30px);
  width: calc(100% + 30px);
  height: 52px;
  left: -15px;
  border-top: 1px solid #f6f6f6;
  border-bottom: 1px solid #fff;
  background-color: #fff;
}

.bar .bar-inner {
  position: relative;
  z-index: 9;
}

.bar .bar-inner:before,
.bar .bar-inner:after {
  content: " ";
  display: table;
}

.bar .bar-inner:after {
  clear: both;
}

.bar .bar-right {
  margin: 10px 0;
  float: right;
}

.toggle-toc {
  cursor: pointer;
  margin-left: 10px;
}

.toggle-toc a {
  display: inline-block;
  line-height: 32px;
  text-align: center;
}

/**
 * footer
 */

.footer {
  color: #999;
}

.footer .copyright {
  font-size: 12px;
}

.footer .copyright a {
  color: #999;
  text-decoration: none;
}

.footer .copyright a:hover {
  color: #0a6ebd;
}

/**
 * .wave-icon
 */

.wave-icon {
  display: inline-block;
  position: relative;
}

.wave-icon .wave-circle {
  display: block;
  border-radius: 50%;
  background-color: transparent;
}

.wave-icon .wave-circle:before,
.wave-icon .wave-circle:after {
  content: '';
  border: 10px solid #2196f3;
  background: #2196f3;
  border-radius: 50%;
  position: absolute;
  top: 50%;
  left: 50%;
  z-index: 1;
}

.wave-icon .wave-circle:before {
  height: 74px;
  width: 74px;
  -webkit-animation: pulse 5s ease-out;
  animation: pulse 5s ease-out;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
  margin-top: -37px;
  margin-left: -37px;
  opacity: 0;
}

.wave-icon .wave-circle:after {
  height: 98px;
  width: 98px;
  -webkit-animation: pulse 5s ease-out;
  animation: pulse 5s ease-out;
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
  margin-top: -49px;
  margin-left: -49px;
  opacity: 0.3;
}

.wave-icon .icon {
  position: relative;
  display: block;
  width: 50px;
  height: 50px;
  line-height: 50px;
  text-align: center;
  background-color: #2196f3;
  border-radius: 50%;
  font-size: 24px;
  color: #fff;
  z-index: 2;
}

.wave-icon.wave-icon-info .wave-circle:before,
.wave-icon.wave-icon-info .wave-circle:after {
  border: 10px solid #56CCF2;
  background: #56CCF2;
}

.wave-icon.wave-icon-info .icon {
  background-color: #56CCF2;
}

.wave-icon.wave-icon-primary .wave-circle:before,
.wave-icon.wave-icon-primary .wave-circle:after {
  border: 10px solid #2196f3;
  background: #2196f3;
}

.wave-icon.wave-icon-primary .icon {
  background-color: #2196f3;
}

.wave-icon.wave-icon-warning .wave-circle:before,
.wave-icon.wave-icon-warning .wave-circle:after {
  border: 10px solid #F09819;
  background: #F09819;
}

.wave-icon.wave-icon-warning .icon {
  background-color: #F09819;
}

.wave-icon.wave-icon-success .wave-circle:before,
.wave-icon.wave-icon-success .wave-circle:after {
  border: 10px solid #5cb85c;
  background: #5cb85c;
}

.wave-icon.wave-icon-success .icon {
  background-color: #5cb85c;
}

.wave-icon.wave-icon-danger .wave-circle:before,
.wave-icon.wave-icon-danger .wave-circle:after {
  border: 10px solid #FF512F;
  background: #FF512F;
}

.wave-icon.wave-icon-danger .icon {
  background-color: #FF512F;
}

@-webkit-keyframes pulse {
  0% {
    -webkit-transform: scale(0);
    opacity: 0.0;
  }

  25% {
    -webkit-transform: scale(0);
    opacity: 0.1;
  }

  50% {
    -webkit-transform: scale(0.1);
    opacity: 0.3;
  }

  75% {
    -webkit-transform: scale(0.5);
    opacity: 0.5;
  }

  100% {
    -webkit-transform: scale(1);
    opacity: 0.0;
  }
}

.repo-list {
  list-style: none;
  padding-left: 0;
}

.repo {
  position: relative;
  list-style-type: none;
  border: 1px solid #f2f2f2;
  margin-bottom: 15px;
  overflow: hidden;
}

.repo-title {
  padding: 0 15px;
  margin: 15px 0;
  font-size: 16px;
  font-weight: 600;
}

.repo-body {
  display: -webkit-box;
  padding: 0 15px;
  margin: 0 0 20px;
  overflow: hidden;
  text-overflow: ellipsis;
  -webkit-box-orient: vertical;
  -webkit-line-clamp: 2;
  line-height: 1.5em;
  height: 3em;
  word-break: break-all !important;
  word-wrap: break-word !important;
}

.repo-image {
  position: relative;
  display: table;
  width: 101%;
  height: 3px;
  margin: -1px -1px 15px;
  background-color: #666;
}

.repo-meta {
  padding: 0 15px;
  margin-top: 5px;
  margin-bottom: 15px;
  color: #777;
  font-size: 12px;
  text-align: right;
}

.repo-meta:before,
.repo-meta:after {
  content: " ";
  display: table;
}

.repo-meta:after {
  clear: both;
}

.repo-meta .meta + .meta {
  margin-left: 15px;
}

/*
 * Global add-ons
 */

.text-collapsed {
  display: none;
}

.text-in {
  display: inline-block;
}

.collapsed .text-collapsed {
  display: inline-block;
}

.collapsed .text-in {
  display: none;
}

.sub-header {
  padding-bottom: 10px;
  border-bottom: 1px solid #eee;
}

.article-header {
  margin-bottom: 20px;
}

.article-footer {
  margin-top: 20px;
}

/**
 * collection
 */

.collection {
  position: relative;
}

.collection a.collection-item {
  display: block;
  -webkit-transition: .25s;
  transition: .25s;
  color: #777777;
}

.collection a:not(.active):hover {
  color: #333333;
}

.collection .collection-item {
  padding: 8px 0;
  margin: 0;
}

.article-list .article-title {
  font-size: 18px;
}

.article-toc .toc-title {
  font-size: 18px;
  color: #000;
}

.article-toc .toc {
  list-style: none;
  padding-left: 0;
  line-height: 2.0;
}

.article-toc .toc ol {
  list-style: none;
  padding-left: 10px;
}

.article-toc .toc .toc-item {
  position: relative;
}

.article-toc .toc .toc-item .markdownIt-Anchor {
  position: absolute;
  left: 0;
  right: 0;
  top: 0;
  padding: 14px 0;
}

.marked-body h1,
.marked-body h2,
.marked-body h3,
.marked-body h4,
.marked-body h5,
.marked-body h6 {
  margin-top: 24px;
  margin-bottom: 16px;
  font-weight: 600;
  line-height: 1.25;
}

.marked-body h1 {
  padding-bottom: 0.3em;
  font-size: 2em;
  border-bottom: 1px solid #f2f2f2;
}

.marked-body h2 {
  padding-bottom: 0.3em;
  font-size: 1.5em;
  border-bottom: 1px solid #f2f2f2;
}

.marked-body a {
  color: #2196f3;
  text-decoration: none;
}

.marked-body a:focus,
.marked-body a:hover {
  color: #0a6ebd;
  text-decoration: none;
}

.marked-body ul,
.marked-body ol {
  padding-left: 0;
  margin-left: 20px;
}

/*
 * We are hiding the invisible nav outside the screen
 * so we need to avoid the horizontal scroll
 */

body.okayNav-loaded {
  overflow-x: hidden;
}

.okayNav {
  position: relative;
}

.okayNav:before,
.okayNav:after {
  content: " ";
  display: table;
}

.okayNav:after {
  clear: both;
}

.okayNav:not(.loaded) {
  visibility: hidden;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
}

.okayNav ul {
  /* We want two navigations - one hidden and one visible */
  float: left;
  padding-left: 0;
}

.okayNav ul li {
  display: inline-block;
  margin-left: 15px;
}

.okayNav a {
  position: relative;
  z-index: 1;
}

.okayNav a.active {
  color: #0a6ebd;
}

.okayNav__nav--visible {
  overflow: hidden;
  white-space: nowrap;
}

.okayNav__nav--visible li {
  display: inline-block;
  margin-left: 15px;
}

.okayNav__nav--visible li:first-child {
  margin-left: 0;
}

.okayNav__nav--visible a {
  /* Link styling for the visible part of the nav */
  display: block;
  -webkit-transition: color 200ms cubic-bezier(0.55, 0, 0.1, 1);
  transition: color 200ms cubic-bezier(0.55, 0, 0.1, 1);
}

.okayNav__nav--visible:empty ~ .okayNav__menu-toggle {
  top: 0;
}

/* Link styling for the off-screen part of the nav */

.okayNav__nav--invisible {
  display: none;
  position: absolute;
  width: 100%;
  top: 24px;
  overflow-y: auto;
  -webkit-overflow-scrolling: touch;
  -webkit-box-shadow: 0 1px 2px rgba(0, 0, 0, 0.05);
  box-shadow: 0 1px 2px rgba(0, 0, 0, 0.05);
  padding-top: 15px;
  padding-bottom: 15px;
  background: #fff;
}

.okayNav__nav--invisible li {
  display: inline-block;
}

.okayNav__nav--invisible li a {
  display: block;
  padding: 6px 15px;
  min-width: 100px;
}

.okayNav__nav--invisible.nav-left {
  left: 0;
}

.okayNav__nav--invisible.nav-right {
  right: 0;
}

.okayNav__nav--invisible.transition-enabled {
  -webkit-transition: -webkit-transform 400ms cubic-bezier(0.55, 0, 0.1, 1);
  transition: -webkit-transform 400ms cubic-bezier(0.55, 0, 0.1, 1);
  transition: transform 400ms cubic-bezier(0.55, 0, 0.1, 1);
  transition: transform 400ms cubic-bezier(0.55, 0, 0.1, 1),-webkit-transform 400ms cubic-bezier(0.55, 0, 0.1, 1);
}

.okayNav__nav--invisible.nav-open {
  display: block;
  z-index: 99;
  border: 1px solid #f2f2f2;
}

/* Kebab icon */

.okayNav__menu-toggle {
  position: relative;
  z-index: 1;
  float: right;
  cursor: pointer;
  -webkit-transition: -webkit-transform 400ms cubic-bezier(0.55, 0, 0.1, 1);
  transition: -webkit-transform 400ms cubic-bezier(0.55, 0, 0.1, 1);
  transition: transform 400ms cubic-bezier(0.55, 0, 0.1, 1);
  transition: transform 400ms cubic-bezier(0.55, 0, 0.1, 1),-webkit-transform 400ms cubic-bezier(0.55, 0, 0.1, 1);
}

.okayNav__menu-toggle.okay-invisible {
  position: absolute;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  pointer-events: none;
  opacity: 0;
}

.okayNav__menu-toggle span {
  background: #666;
  display: inline-block;
  width: 2px;
  height: 2px;
  margin: auto 1px;
  pointer-events: none;
  border-radius: 50%;
  vertical-align: middle;
}

.okayNav__menu-toggle.icon--active {
  /* Kebab icon when off-screen nav is open */
}

.okayNav__menu-toggle.icon--active span {
  background: #0a6ebd;
}

.okayNav a {
  color: #2e2e33;
  font-weight: 400;
}

.okayNav a:hover {
  color: #0a6ebd;
}

/**
 * social-links
 */

.social-links {
  list-style: none;
  padding: 0;
  text-align: left;
}

.social-links li {
  list-style: none;
  display: inline-block;
  margin-left: 10px;
}

.social-links li:first-child {
  margin-left: 0;
}

.header .social-links {
  padding: 10px 20px;
}

.footer .social-links {
  margin-bottom: 5px;
}

@font-face {
  font-family: "socialshare";
  src: url("../fonts/iconfont.eot");
  /* IE9*/
  src: url("../fonts/iconfont.eot?#iefix") format("embedded-opentype"),url("../fonts/iconfont.woff") format("woff"),url("../fonts/iconfont.ttf") format("truetype"),url("../fonts/iconfont.svg#iconfont") format("svg");
}

.social-share {
  display: inline-block;
  font-size: 16px;
}

.social-share a {
  position: relative;
  text-decoration: none;
  margin-left: 16px;
  display: inline-block;
  outline: none;
  line-height: 32px;
}

.social-share .social-share-icon {
  position: relative;
  display: inline-block;
  height: 32px;
  line-height: 32px;
  color: #999;
  text-align: center;
  vertical-align: middle;
  -webkit-transition: background 0.6s ease-out 0s;
  transition: background 0.6s ease-out 0s;
}

.social-share .social-share-icon:hover {
  color: #666;
}

.social-share .icon-weibo:hover {
  color: #ff763b;
}

.social-share .icon-tencent:hover {
  color: #56b6e7;
}

.social-share .icon-qq:hover {
  color: #56b6e7;
}

.social-share .icon-qzone:hover {
  color: #FDBE3D;
}

.social-share .icon-douban:hover {
  color: #33b045;
}

.social-share .icon-linkedin:hover {
  color: #0077B5;
}

.social-share .icon-facebook:hover {
  color: #44619D;
}

.social-share .icon-google:hover {
  color: #db4437;
}

.social-share .icon-twitter:hover {
  color: #55acee;
}

.social-share .icon-diandian:hover {
  color: #307DCA;
}

.social-share .icon-wechat {
  position: relative;
}

.social-share .icon-wechat:hover {
  color: #7bc549;
}

.social-share .icon-wechat .wechat-qrcode {
  display: none;
  border: 1px solid #eee;
  position: absolute;
  z-index: 9;
  top: -209px;
  left: -90px;
  width: 200px;
  height: 200px;
  color: #666;
  font-size: 12px;
  text-align: center;
  background-color: #fff;
  -webkit-transition: all 200ms;
  transition: all 200ms;
  -webkit-tansition: all 350ms;
  -moz-transition: all 350ms;
}

.social-share .icon-wechat .wechat-qrcode.bottom {
  top: 40px;
  left: -84px;
}

.social-share .icon-wechat .wechat-qrcode.bottom:after {
  display: none;
}

.social-share .icon-wechat .wechat-qrcode h4 {
  font-weight: normal;
  height: 26px;
  line-height: 26px;
  font-size: 12px;
  background-color: #f3f3f3;
  margin: 0;
  padding: 0;
  color: #777;
}

.social-share .icon-wechat .wechat-qrcode .qrcode {
  width: 105px;
  margin: 15px auto;
}

.social-share .icon-wechat .wechat-qrcode .qrcode table {
  margin: 0 !important;
}

.social-share .icon-wechat .wechat-qrcode .help p {
  font-weight: normal;
  line-height: 16px;
  padding: 0;
  margin: 0;
}

.social-share .icon-wechat .wechat-qrcode:before {
  content: '';
  position: absolute;
  left: 50%;
  margin-left: -6px;
  bottom: -15px;
  width: 0;
  height: 0;
  border-width: 8px 6px 6px 6px;
  border-style: solid;
  border-color: #eee transparent transparent transparent;
}

.social-share .icon-wechat .wechat-qrcode:after {
  content: '';
  position: absolute;
  left: 50%;
  margin-left: -6px;
  bottom: -13px;
  width: 0;
  height: 0;
  border-width: 8px 6px 6px 6px;
  border-style: solid;
  border-color: #fff transparent transparent transparent;
}

.social-share .icon-wechat:hover .wechat-qrcode {
  display: block;
}

.btn-donate {
  position: absolute;
  bottom: 10px;
  left: 50%;
  margin-left: -25px;
  width: 50px;
  height: 50px;
  line-height: 50px;
  padding: 0;
  border-radius: 50%;
  font-size: 18px;
  cursor: pointer;
  z-index: 99;
}

.btn-donate:focus,
.btn-donate:hover,
.btn-donate:active {
  border-color: transparent !important;
  outline: none !important;
}

.btn-donate.btn-fancy {
  background-color: transparent;
}

.btn-donate.btn-fancy span {
  width: 50px;
  height: 50px;
  padding: 0;
}

.donate {
  overflow: hidden;
}

.donate-box {
  text-align: center;
  padding-top: 30px;
}

.donate-box .donate-head {
  width: 100%;
  height: 80px;
  text-align: center;
  line-height: 60px;
  color: #a3a3a3;
  font-size: 16px;
  position: relative;
}

.donate-box .donate-head:before,
.donate-box .donate-head:after {
  font-family: Arial,Helvetica,sans-serif;
  background: none;
  width: 0px;
  height: 0px;
  font-style: normal;
  color: #eee;
  font-size: 100px;
  position: absolute;
  top: 15px;
}

.donate-box .donate-head:before {
  content: '\201c';
  left: 30px;
}

.donate-box .donate-head:after {
  content: '\201d';
  right: 70px;
}

.donate-box .donate-footer {
  padding-top: 35px;
}

.donate-box .donate-payimg {
  display: inline-block;
  padding: 10px;
  border: 6px solid #ea5f00;
  margin: 0 auto;
  border-radius: 3px;
}

.donate-box .donate-payimg img {
  display: block;
  text-align: center;
  width: 140px;
  height: 140px;
}

.book .media-middle {
  display: inline-block;
  width: 115px;
}

.ins-search {
  display: none;
}

.ins-search.show {
  display: block;
}

.ins-selectable {
  cursor: pointer;
}

.ins-search-mask,
.ins-search-container {
  position: fixed;
}

.ins-search-mask {
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  z-index: 1050;
  background: rgba(0, 0, 0, 0.5);
}

.ins-input-wrapper {
  position: relative;
}

.ins-search-input {
  width: 100%;
  border: none;
  outline: none;
  font-size: 16px;
  -webkit-box-shadow: none;
  box-shadow: none;
  font-weight: 200;
  border-radius: 0;
  background: #fff;
  line-height: 20px;
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
  padding: 12px 28px 12px 20px;
  border-bottom: 1px solid #e2e2e2;
  font-family: "Microsoft Yahei Light","Microsoft Yahei",Helvetica,Arial,sans-serif;
}

.ins-close {
  top: 50%;
  right: 6px;
  width: 20px;
  height: 20px;
  font-size: 24px;
  margin-top: -15px;
  position: absolute;
  text-align: center;
  opacity: 1.0;
  color: #666;
  display: inline-block;
}

.ins-close:hover {
  color: #006bde;
}

.ins-search-container {
  left: 50%;
  top: 100px;
  z-index: 1051;
  bottom: 100px;
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
  width: 540px;
  margin-left: -270px;
}

.ins-section-wrapper {
  left: 0;
  right: 0;
  top: 45px;
  bottom: 0;
  overflow-y: auto;
  position: absolute;
}

.ins-section-container {
  position: relative;
  background: #f7f7f7;
}

.ins-section {
  font-size: 14px;
  line-height: 16px;
}

.ins-section .ins-section-header,
.ins-section .ins-search-item {
  padding: 8px 15px;
}

.ins-section .ins-section-header {
  color: #9a9a9a;
  border-bottom: 1px solid #e2e2e2;
}

.ins-section .ins-slug {
  margin-left: 5px;
  color: #9a9a9a;
}

.ins-section .ins-slug:before {
  content: '(';
}

.ins-section .ins-slug:after {
  content: ')';
}

.ins-section .ins-search-item header,
.ins-section .ins-search-item .ins-search-preview {
  overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis;
}

.ins-section .ins-search-item header .icon {
  margin-right: 8px;
}

.ins-section .ins-search-item .ins-search-preview {
  height: 15px;
  font-size: 12px;
  color: #9a9a9a;
  margin: 5px 0 0 20px;
}

.ins-section .ins-search-item:hover,
.ins-section .ins-search-item.active {
  color: #fff;
  background: #006bde;
}

.ins-section .ins-search-item:hover .ins-slug,
.ins-section .ins-search-item.active .ins-slug,
.ins-section .ins-search-item:hover .ins-search-preview,
.ins-section .ins-search-item.active .ins-search-preview {
  color: #fff;
}

.theme-black .header,
.theme-blue .header,
.theme-green .header,
.theme-purple .header {
  color: #fff;
}

.theme-black .header a,
.theme-blue .header a,
.theme-green .header a,
.theme-purple .header a {
  color: #efefef;
}

.theme-black .header #location,
.theme-blue .header #location,
.theme-green .header #location,
.theme-purple .header #location {
  color: rgba(255, 255, 255, 0.75) !important;
}

.theme-black .header .navbar-toggle .icon-bar,
.theme-blue .header .navbar-toggle .icon-bar,
.theme-green .header .navbar-toggle .icon-bar,
.theme-purple .header .navbar-toggle .icon-bar {
  background-color: #fff;
}

.theme-black .footer,
.theme-blue .footer,
.theme-green .footer,
.theme-purple .footer {
  color: rgba(255, 255, 255, 0.75);
}

.theme-black .footer a,
.theme-blue .footer a,
.theme-green .footer a,
.theme-purple .footer a {
  color: rgba(255, 255, 255, 0.75);
}

.theme-black .header a:focus,
.theme-black .header a:hover,
.theme-black .header a.active,
.theme-black .footer a:focus,
.theme-black .footer a:hover,
.theme-black .footer a.active,
.theme-blue .header a:focus,
.theme-blue .header a:hover,
.theme-blue .header a.active,
.theme-blue .footer a:focus,
.theme-blue .footer a:hover,
.theme-blue .footer a.active,
.theme-green .header a:focus,
.theme-green .header a:hover,
.theme-green .header a.active,
.theme-green .footer a:focus,
.theme-green .footer a:hover,
.theme-green .footer a.active,
.theme-purple .header a:focus,
.theme-purple .header a:hover,
.theme-purple .header a.active,
.theme-purple .footer a:focus,
.theme-purple .footer a:hover,
.theme-purple .footer a.active {
  color: #fff;
}

.theme-black .main-nav > li > a:focus,
.theme-black .main-nav > li > a:hover,
.theme-black .main-nav > li > a.active,
.theme-blue .main-nav > li > a:focus,
.theme-blue .main-nav > li > a:hover,
.theme-blue .main-nav > li > a.active,
.theme-green .main-nav > li > a:focus,
.theme-green .main-nav > li > a:hover,
.theme-green .main-nav > li > a.active,
.theme-purple .main-nav > li > a:focus,
.theme-purple .main-nav > li > a:hover,
.theme-purple .main-nav > li > a.active {
  color: #fff;
  background: rgba(0, 0, 0, 0.15);
}

.theme-black .main-nav > .active a,
.theme-black .main-nav > .active a:focus,
.theme-black .main-nav > .active a:hover,
.theme-black .main-nav > .active a.active,
.theme-blue .main-nav > .active a,
.theme-blue .main-nav > .active a:focus,
.theme-blue .main-nav > .active a:hover,
.theme-blue .main-nav > .active a.active,
.theme-green .main-nav > .active a,
.theme-green .main-nav > .active a:focus,
.theme-green .main-nav > .active a:hover,
.theme-green .main-nav > .active a.active,
.theme-purple .main-nav > .active a,
.theme-purple .main-nav > .active a:focus,
.theme-purple .main-nav > .active a:hover,
.theme-purple .main-nav > .active a.active {
  color: #fff;
  background: rgba(0, 0, 0, 0.2);
}

.theme-black .search .sidebar-form,
.theme-blue .search .sidebar-form,
.theme-green .search .sidebar-form,
.theme-purple .search .sidebar-form {
  border: 0;
  background: rgba(0, 0, 0, 0.2);
}

.theme-black .search .sidebar-form input::-webkit-input-placeholder,
.theme-blue .search .sidebar-form input::-webkit-input-placeholder,
.theme-green .search .sidebar-form input::-webkit-input-placeholder,
.theme-purple .search .sidebar-form input::-webkit-input-placeholder {
  color: rgba(255, 255, 255, 0.5);
}

.theme-black .search .sidebar-form input:-moz-placeholder,
.theme-blue .search .sidebar-form input:-moz-placeholder,
.theme-green .search .sidebar-form input:-moz-placeholder,
.theme-purple .search .sidebar-form input:-moz-placeholder {
  color: rgba(255, 255, 255, 0.5);
}

.theme-black .search .sidebar-form input::-moz-placeholder,
.theme-blue .search .sidebar-form input::-moz-placeholder,
.theme-green .search .sidebar-form input::-moz-placeholder,
.theme-purple .search .sidebar-form input::-moz-placeholder {
  color: rgba(255, 255, 255, 0.5);
}

.theme-black .search .sidebar-form input:-ms-input-placeholder,
.theme-blue .search .sidebar-form input:-ms-input-placeholder,
.theme-green .search .sidebar-form input:-ms-input-placeholder,
.theme-purple .search .sidebar-form input:-ms-input-placeholder {
  color: rgba(255, 255, 255, 0.5);
}

.theme-black .search input[type="text"],
.theme-blue .search input[type="text"],
.theme-green .search input[type="text"],
.theme-purple .search input[type="text"] {
  color: #666;
}

.theme-black .search input[type="text"] + .input-group-btn .btn,
.theme-blue .search input[type="text"] + .input-group-btn .btn,
.theme-green .search input[type="text"] + .input-group-btn .btn,
.theme-purple .search input[type="text"] + .input-group-btn .btn {
  color: rgba(255, 255, 255, 0.5);
}

.theme-black .search input[type="text"]:focus,
.theme-black .search input[type="text"]:focus + .input-group-btn .btn,
.theme-blue .search input[type="text"]:focus,
.theme-blue .search input[type="text"]:focus + .input-group-btn .btn,
.theme-green .search input[type="text"]:focus,
.theme-green .search input[type="text"]:focus + .input-group-btn .btn,
.theme-purple .search input[type="text"]:focus,
.theme-purple .search input[type="text"]:focus + .input-group-btn .btn {
  background-color: #fff;
  color: #666;
}

.theme-black .header {
  background: #1a2433;
  background: -webkit-linear-gradient(left, #1a2433 0%, #253449 80%, #253449 100%);
  background: -webkit-gradient(linear, left top, right top, from(#1a2433), color-stop(80%, #253449), to(#253449));
  background: linear-gradient(to right, #1a2433 0%, #253449 80%, #253449 100%);
}

.theme-blue .header {
  background: #0062c5;
  background: -webkit-linear-gradient(left, #0062c5 0%, #0073e6 80%, #0073e6 100%);
  background: -webkit-gradient(linear, left top, right top, from(#0062c5), color-stop(80%, #0073e6), to(#0073e6));
  background: linear-gradient(to right, #0062c5 0%, #0073e6 80%, #0073e6 100%);
}

.theme-green .header {
  background: #08a283;
  background: -webkit-linear-gradient(left, #08a283 0%, #0ac29d 80%, #0ac29d 100%);
  background: -webkit-gradient(linear, left top, right top, from(#08a283), color-stop(80%, #0ac29d), to(#0ac29d));
  background: linear-gradient(to right, #08a283 0%, #0ac29d 80%, #0ac29d 100%);
}

.theme-purple .header {
  background: #494683;
  background: -webkit-linear-gradient(left, #494683 0%, #555299 80%, #555299 100%);
  background: -webkit-gradient(linear, left top, right top, from(#494683), color-stop(80%, #555299), to(#555299));
  background: linear-gradient(to right, #494683 0%, #555299 80%, #555299 100%);
}

@media (min-width: 767px) {
  .modal-center {
    text-align: center;
    padding: 0 !important;
  }

  .modal-center:before {
    content: '';
    display: inline-block;
    height: 100%;
    vertical-align: middle;
    margin-right: -4px;
  }

  .modal-center .modal-dialog {
    display: inline-block;
    text-align: left;
    vertical-align: middle;
  }

  .donate-box .donate-footer {
    margin: 0 -15px -16px -15px;
  }
}

@media (min-width: 768px) {
  .lead {
    font-size: 21px;
  }

  .dl-horizontal dt {
    float: left;
    width: 160px;
    clear: left;
    text-align: right;
    overflow: hidden;
    text-overflow: ellipsis;
    white-space: nowrap;
  }

  .dl-horizontal dd {
    margin-left: 180px;
  }

  .container {
    width: 750px;
  }

  .col-sm-1,
  .col-sm-2,
  .col-sm-3,
  .col-sm-4,
  .col-sm-5,
  .col-sm-6,
  .col-sm-7,
  .col-sm-8,
  .col-sm-9,
  .col-sm-10,
  .col-sm-11,
  .col-sm-12 {
    float: left;
  }

  .col-sm-1 {
    width: 8.33333%;
  }

  .col-sm-2 {
    width: 16.66667%;
  }

  .col-sm-3 {
    width: 25%;
  }

  .col-sm-4 {
    width: 33.33333%;
  }

  .col-sm-5 {
    width: 41.66667%;
  }

  .col-sm-6 {
    width: 50%;
  }

  .col-sm-7 {
    width: 58.33333%;
  }

  .col-sm-8 {
    width: 66.66667%;
  }

  .col-sm-9 {
    width: 75%;
  }

  .col-sm-10 {
    width: 83.33333%;
  }

  .col-sm-11 {
    width: 91.66667%;
  }

  .col-sm-12 {
    width: 100%;
  }

  .col-sm-pull-0 {
    right: auto;
  }

  .col-sm-pull-1 {
    right: 8.33333%;
  }

  .col-sm-pull-2 {
    right: 16.66667%;
  }

  .col-sm-pull-3 {
    right: 25%;
  }

  .col-sm-pull-4 {
    right: 33.33333%;
  }

  .col-sm-pull-5 {
    right: 41.66667%;
  }

  .col-sm-pull-6 {
    right: 50%;
  }

  .col-sm-pull-7 {
    right: 58.33333%;
  }

  .col-sm-pull-8 {
    right: 66.66667%;
  }

  .col-sm-pull-9 {
    right: 75%;
  }

  .col-sm-pull-10 {
    right: 83.33333%;
  }

  .col-sm-pull-11 {
    right: 91.66667%;
  }

  .col-sm-pull-12 {
    right: 100%;
  }

  .col-sm-push-0 {
    left: auto;
  }

  .col-sm-push-1 {
    left: 8.33333%;
  }

  .col-sm-push-2 {
    left: 16.66667%;
  }

  .col-sm-push-3 {
    left: 25%;
  }

  .col-sm-push-4 {
    left: 33.33333%;
  }

  .col-sm-push-5 {
    left: 41.66667%;
  }

  .col-sm-push-6 {
    left: 50%;
  }

  .col-sm-push-7 {
    left: 58.33333%;
  }

  .col-sm-push-8 {
    left: 66.66667%;
  }

  .col-sm-push-9 {
    left: 75%;
  }

  .col-sm-push-10 {
    left: 83.33333%;
  }

  .col-sm-push-11 {
    left: 91.66667%;
  }

  .col-sm-push-12 {
    left: 100%;
  }

  .col-sm-offset-0 {
    margin-left: 0%;
  }

  .col-sm-offset-1 {
    margin-left: 8.33333%;
  }

  .col-sm-offset-2 {
    margin-left: 16.66667%;
  }

  .col-sm-offset-3 {
    margin-left: 25%;
  }

  .col-sm-offset-4 {
    margin-left: 33.33333%;
  }

  .col-sm-offset-5 {
    margin-left: 41.66667%;
  }

  .col-sm-offset-6 {
    margin-left: 50%;
  }

  .col-sm-offset-7 {
    margin-left: 58.33333%;
  }

  .col-sm-offset-8 {
    margin-left: 66.66667%;
  }

  .col-sm-offset-9 {
    margin-left: 75%;
  }

  .col-sm-offset-10 {
    margin-left: 83.33333%;
  }

  .col-sm-offset-11 {
    margin-left: 91.66667%;
  }

  .col-sm-offset-12 {
    margin-left: 100%;
  }

  .navbar-right .dropdown-menu {
    right: 0;
    left: auto;
  }

  .navbar-right .dropdown-menu-left {
    left: 0;
    right: auto;
  }

  .nav-justified > li,
  .nav-tabs.nav-justified > li {
    display: table-cell;
    width: 1%;
  }

  .nav-justified > li > a,
  .nav-tabs.nav-justified > li > a {
    margin-bottom: 0;
  }

  .nav-tabs-justified > li > a,
  .nav-tabs.nav-justified > li > a {
    border-bottom: 1px solid #f2f2f2;
    border-radius: 4px 4px 0 0;
  }

  .nav-tabs-justified > .active > a,
  .nav-tabs.nav-justified > .active > a,
  .nav-tabs-justified > .active > a:hover,
  .nav-tabs.nav-justified > .active > a:hover,
  .nav-tabs-justified > .active > a:focus,
  .nav-tabs.nav-justified > .active > a:focus {
    border-bottom-color: #fff;
  }

  .navbar {
    border-radius: 4px;
  }

  .navbar-header {
    float: left;
  }

  .navbar-collapse {
    width: auto;
    border-top: 0;
    -webkit-box-shadow: none;
    box-shadow: none;
  }

  .navbar-collapse.collapse {
    display: block !important;
    height: auto !important;
    padding-bottom: 0;
    overflow: visible !important;
  }

  .navbar-collapse.in {
    overflow-y: visible;
  }

  .navbar-fixed-top .navbar-collapse,
  .navbar-static-top .navbar-collapse,
  .navbar-fixed-bottom .navbar-collapse {
    padding-left: 0;
    padding-right: 0;
  }

  .container > .navbar-header,
  .container > .navbar-collapse,
  .container-fluid > .navbar-header,
  .container-fluid > .navbar-collapse {
    margin-right: 0;
    margin-left: 0;
  }

  .navbar-static-top {
    border-radius: 0;
  }

  .navbar-fixed-top,
  .navbar-fixed-bottom {
    border-radius: 0;
  }

  .navbar > .container .navbar-brand,
  .navbar > .container-fluid .navbar-brand {
    margin-left: -15px;
  }

  .navbar-toggle {
    display: none;
  }

  .navbar-nav {
    float: left;
    margin: 0;
  }

  .navbar-nav > li {
    float: left;
  }

  .navbar-nav > li > a {
    padding-top: 14.5px;
    padding-bottom: 14.5px;
  }

  .navbar-form .form-group {
    display: inline-block;
    margin-bottom: 0;
    vertical-align: middle;
  }

  .navbar-form .form-control {
    display: inline-block;
    width: auto;
    vertical-align: middle;
  }

  .navbar-form .form-control-static {
    display: inline-block;
  }

  .navbar-form .input-group {
    display: inline-table;
    vertical-align: middle;
  }

  .navbar-form .input-group .input-group-addon,
  .navbar-form .input-group .input-group-btn,
  .navbar-form .input-group .form-control {
    width: auto;
  }

  .navbar-form .input-group > .form-control {
    width: 100%;
  }

  .navbar-form .control-label {
    margin-bottom: 0;
    vertical-align: middle;
  }

  .navbar-form .radio,
  .navbar-form .checkbox {
    display: inline-block;
    margin-top: 0;
    margin-bottom: 0;
    vertical-align: middle;
  }

  .navbar-form .radio label,
  .navbar-form .checkbox label {
    padding-left: 0;
  }

  .navbar-form .radio input[type="radio"],
  .navbar-form .checkbox input[type="checkbox"] {
    position: relative;
    margin-left: 0;
  }

  .navbar-form .has-feedback .form-control-feedback {
    top: 0;
  }

  .navbar-form {
    width: auto;
    border: 0;
    margin-left: 0;
    margin-right: 0;
    padding-top: 0;
    padding-bottom: 0;
    -webkit-box-shadow: none;
    box-shadow: none;
  }

  .navbar-text {
    float: left;
    margin-left: 15px;
    margin-right: 15px;
  }

  .navbar-left {
    float: left !important;
  }

  .navbar-right {
    float: right !important;
    margin-right: -15px;
  }

  .navbar-right ~ .navbar-right {
    margin-right: 0;
  }

  .modal-dialog {
    width: 600px;
    margin: 30px auto;
  }

  .modal-content {
    -webkit-box-shadow: 0 5px 15px rgba(0, 0, 0, 0.05);
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.05);
  }

  .modal-sm {
    width: 300px;
  }

  .header {
    position: fixed;
    top: 0;
    bottom: 0;
    left: 0;
    z-index: 1000;
    display: block;
    padding: 0;
    overflow-y: auto;
    /* Scrollable contents if viewport is shorter than content. */
    border-right: 1px solid #f6f6f6;
    width: 4.16667%;
  }

  .sidebar {
    position: fixed;
    top: 0;
    bottom: 0;
    left: 0;
    display: block;
    padding: 0;
    overflow-x: hidden;
    overflow-y: auto;
    /* Scrollable contents if viewport is shorter than content. */
    border-right: 1px solid #f6f6f6;
    width: 33.33333%;
  }

  .main {
    width: 62.5%;
    padding-right: 20px;
    padding-left: 20px;
  }

  .footer {
    position: fixed;
    left: 0;
    bottom: 0;
    background-color: transparent;
    z-index: 1050;
    width: 4.16667%;
  }

  body.main-center .main {
    margin-left: 4.16667%;
  }

  body.main-left .sidebar {
    margin-right: 4.16667%;
  }

  body.main-right .sidebar {
    margin-left: 4.16667%;
  }

  body.main-right .main {
    margin-left: 37.5%;
  }

  body.no-sidebar.main-left .main {
    width: 95.83333333%;
    margin-right: 4.16667%;
  }

  body.no-sidebar.main-right .main,
  body.no-sidebar.main-center .main {
    width: 95.83333333%;
    margin-left: 4.16667%;
  }

  .header .navbar-header {
    float: none;
  }

  #avatar img {
    padding: 5px;
  }

  .bar.bar-footer:before {
    width: -webkit-calc(100% + 40px);
    width: calc(100% + 40px);
    left: -20px;
  }

  .header .social-links {
    display: none;
  }
}

@media (min-width: 992px) {
  
  .slimContent{
    margin-top: 20px;
  }

  .container {
    width: 970px;
  }

  .col-md-1,
  .col-md-2,
  .col-md-3,
  .col-md-4,
  .col-md-5,
  .col-md-6,
  .col-md-7,
  .col-md-8,
  .col-md-9,
  .col-md-10,
  .col-md-11,
  .col-md-12 {
    float: left;
  }

  .col-md-1 {
    width: 8.33333%;
  }

  .col-md-2 {
    width: 16.66667%;
  }

  .col-md-3 {
    width: 25%;
  }

  .col-md-4 {
    width: 33.33333%;
  }

  .col-md-5 {
    width: 41.66667%;
  }

  .col-md-6 {
    width: 50%;
  }

  .col-md-7 {
    width: 58.33333%;
  }

  .col-md-8 {
    width: 66.66667%;
  }

  .col-md-9 {
    width: 75%;
  }

  .col-md-10 {
    width: 83.33333%;
  }

  .col-md-11 {
    width: 91.66667%;
  }

  .col-md-12 {
    width: 100%;
  }

  .col-md-pull-0 {
    right: auto;
  }

  .col-md-pull-1 {
    right: 8.33333%;
  }

  .col-md-pull-2 {
    right: 16.66667%;
  }

  .col-md-pull-3 {
    right: 25%;
  }

  .col-md-pull-4 {
    right: 33.33333%;
  }

  .col-md-pull-5 {
    right: 41.66667%;
  }

  .col-md-pull-6 {
    right: 50%;
  }

  .col-md-pull-7 {
    right: 58.33333%;
  }

  .col-md-pull-8 {
    right: 66.66667%;
  }

  .col-md-pull-9 {
    right: 75%;
  }

  .col-md-pull-10 {
    right: 83.33333%;
  }

  .col-md-pull-11 {
    right: 91.66667%;
  }

  .col-md-pull-12 {
    right: 100%;
  }

  .col-md-push-0 {
    left: auto;
  }

  .col-md-push-1 {
    left: 8.33333%;
  }

  .col-md-push-2 {
    left: 16.66667%;
  }

  .col-md-push-3 {
    left: 25%;
  }

  .col-md-push-4 {
    left: 33.33333%;
  }

  .col-md-push-5 {
    left: 41.66667%;
  }

  .col-md-push-6 {
    left: 50%;
  }

  .col-md-push-7 {
    left: 58.33333%;
  }

  .col-md-push-8 {
    left: 66.66667%;
  }

  .col-md-push-9 {
    left: 75%;
  }

  .col-md-push-10 {
    left: 83.33333%;
  }

  .col-md-push-11 {
    left: 91.66667%;
  }

  .col-md-push-12 {
    left: 100%;
  }

  .col-md-offset-0 {
    margin-left: 0%;
  }

  .col-md-offset-1 {
    margin-left: 8.33333%;
  }

  .col-md-offset-2 {
    margin-left: 16.66667%;
  }

  .col-md-offset-3 {
    margin-left: 25%;
  }

  .col-md-offset-4 {
    margin-left: 33.33333%;
  }

  .col-md-offset-5 {
    margin-left: 41.66667%;
  }

  .col-md-offset-6 {
    margin-left: 50%;
  }

  .col-md-offset-7 {
    margin-left: 58.33333%;
  }

  .col-md-offset-8 {
    margin-left: 66.66667%;
  }

  .col-md-offset-9 {
    margin-left: 75%;
  }

  .col-md-offset-10 {
    margin-left: 83.33333%;
  }

  .col-md-offset-11 {
    margin-left: 91.66667%;
  }

  .col-md-offset-12 {
    margin-left: 100%;
  }

  .modal-lg {
    width: 900px;
  }

  .header {
    width: 16.66667%;
  }

  .sidebar {
    width: 25%;
  }

  .sidebar .slimContent {
    padding-right: 25px;
    padding-left: 25px;
  }

  .main {
    width: 58.33333%;
    padding-right: 25px;
    padding-left: 25px;
  }

  .footer {
    width: 16.66667%;
  }

  body.main-center .main {
    margin-left: 16.66667%;
  }

  body.main-left .sidebar {
    margin-right: 16.66667%;
  }

  body.main-right .sidebar {
    margin-left: 16.66667%;
  }

  body.main-right .main {
    margin-left: 41.66667%;
  }

  body.no-sidebar.main-left .main {
    width: 83.33333333%;
    margin-right: 16.66667%;
  }

  body.no-sidebar.main-right .main,
  body.no-sidebar.main-center .main {
    width: 83.33333333%;
    margin-left: 16.66667%;
  }

  .bar.bar-footer:before {
    width: -webkit-calc(100% + 50px);
    width: calc(100% + 50px);
    left: -25px;
  }

  .marked-body .headerlink:before,
  .marked-body .markdownIt-Anchor:before {
    display: inline-block;
    width: 18px;
    content: "#";
    color: #0a6ebd;
    text-align: right;
    float: left;
    visibility: hidden;
  }

  .marked-body .headerlink:before {
    margin-left: -15px;
    padding-right: 2px;
  }

  .marked-body .markdownIt-Anchor:before {
    margin-left: -20px;
  }

  .marked-body h1:hover .headerlink:before,
  .marked-body h1:hover .markdownIt-Anchor:before,
  .marked-body h2:hover .headerlink:before,
  .marked-body h2:hover .markdownIt-Anchor:before,
  .marked-body h3:hover .headerlink:before,
  .marked-body h3:hover .markdownIt-Anchor:before,
  .marked-body h4:hover .headerlink:before,
  .marked-body h4:hover .markdownIt-Anchor:before,
  .marked-body h5:hover .headerlink:before,
  .marked-body h5:hover .markdownIt-Anchor:before,
  .marked-body h6:hover .headerlink:before,
  .marked-body h6:hover .markdownIt-Anchor:before {
    visibility: visible;
  }
}

@media (min-width: 1200px) {
  .container {
    width: 1170px;
  }

  .col-lg-1,
  .col-lg-2,
  .col-lg-3,
  .col-lg-4,
  .col-lg-5,
  .col-lg-6,
  .col-lg-7,
  .col-lg-8,
  .col-lg-9,
  .col-lg-10,
  .col-lg-11,
  .col-lg-12 {
    float: left;
  }

  .col-lg-1 {
    width: 8.33333%;
  }

  .col-lg-2 {
    width: 16.66667%;
  }

  .col-lg-3 {
    width: 25%;
  }

  .col-lg-4 {
    width: 33.33333%;
  }

  .col-lg-5 {
    width: 41.66667%;
  }

  .col-lg-6 {
    width: 50%;
  }

  .col-lg-7 {
    width: 58.33333%;
  }

  .col-lg-8 {
    width: 66.66667%;
  }

  .col-lg-9 {
    width: 75%;
  }

  .col-lg-10 {
    width: 83.33333%;
  }

  .col-lg-11 {
    width: 91.66667%;
  }

  .col-lg-12 {
    width: 100%;
  }

  .col-lg-pull-0 {
    right: auto;
  }

  .col-lg-pull-1 {
    right: 8.33333%;
  }

  .col-lg-pull-2 {
    right: 16.66667%;
  }

  .col-lg-pull-3 {
    right: 25%;
  }

  .col-lg-pull-4 {
    right: 33.33333%;
  }

  .col-lg-pull-5 {
    right: 41.66667%;
  }

  .col-lg-pull-6 {
    right: 50%;
  }

  .col-lg-pull-7 {
    right: 58.33333%;
  }

  .col-lg-pull-8 {
    right: 66.66667%;
  }

  .col-lg-pull-9 {
    right: 75%;
  }

  .col-lg-pull-10 {
    right: 83.33333%;
  }

  .col-lg-pull-11 {
    right: 91.66667%;
  }

  .col-lg-pull-12 {
    right: 100%;
  }

  .col-lg-push-0 {
    left: auto;
  }

  .col-lg-push-1 {
    left: 8.33333%;
  }

  .col-lg-push-2 {
    left: 16.66667%;
  }

  .col-lg-push-3 {
    left: 25%;
  }

  .col-lg-push-4 {
    left: 33.33333%;
  }

  .col-lg-push-5 {
    left: 41.66667%;
  }

  .col-lg-push-6 {
    left: 50%;
  }

  .col-lg-push-7 {
    left: 58.33333%;
  }

  .col-lg-push-8 {
    left: 66.66667%;
  }

  .col-lg-push-9 {
    left: 75%;
  }

  .col-lg-push-10 {
    left: 83.33333%;
  }

  .col-lg-push-11 {
    left: 91.66667%;
  }

  .col-lg-push-12 {
    left: 100%;
  }

  .col-lg-offset-0 {
    margin-left: 0%;
  }

  .col-lg-offset-1 {
    margin-left: 8.33333%;
  }

  .col-lg-offset-2 {
    margin-left: 16.66667%;
  }

  .col-lg-offset-3 {
    margin-left: 25%;
  }

  .col-lg-offset-4 {
    margin-left: 33.33333%;
  }

  .col-lg-offset-5 {
    margin-left: 41.66667%;
  }

  .col-lg-offset-6 {
    margin-left: 50%;
  }

  .col-lg-offset-7 {
    margin-left: 58.33333%;
  }

  .col-lg-offset-8 {
    margin-left: 66.66667%;
  }

  .col-lg-offset-9 {
    margin-left: 75%;
  }

  .col-lg-offset-10 {
    margin-left: 83.33333%;
  }

  .col-lg-offset-11 {
    margin-left: 91.66667%;
  }

  .col-lg-offset-12 {
    margin-left: 100%;
  }

  .visible-lg {
    display: block !important;
  }

  table.visible-lg {
    display: table !important;
  }

  tr.visible-lg {
    display: table-row !important;
  }

  th.visible-lg,
  td.visible-lg {
    display: table-cell !important;
  }

  .visible-lg-block {
    display: block !important;
  }

  .visible-lg-inline {
    display: inline !important;
  }

  .visible-lg-inline-block {
    display: inline-block !important;
  }

  .hidden-lg {
    display: none !important;
  }

  .header {
    width: 16.66667%;
  }

  .sidebar {
    width: 23%;
  }

  .sidebar .slimContent {
    padding-right: 30px;
    padding-left: 30px;
  }

  .main {
    width: 60.33333%;
    padding-right: 30px;
    padding-left: 30px;
  }

  .footer {
    width: 16.66667%;
  }

  body.main-center .main {
    margin-left: 16.66667%;
  }

  body.main-left .sidebar {
    margin-right: 16.66667%;
  }

  body.main-right .sidebar {
    margin-left: 16.66667%;
  }

  body.main-right .main {
    margin-left: 39.66667%;
  }

  body.no-sidebar.main-left .main {
    width: 83.33333333%;
    margin-right: 16.66667%;
  }

  body.no-sidebar.main-right .main,
  body.no-sidebar.main-center .main {
    width: 83.33333333%;
    margin-left: 16.66667%;
  }

  .main-nav > li > a {
    padding: 10px 20px;
  }

  .bar.bar-footer:before {
    width: -webkit-calc(100% + 60px);
    width: calc(100% + 60px);
    left: -30px;
  }
}

@media (min-width: 1440px) {
  .header {
    width: 16.66667%;
  }

  .sidebar {
    width: 21%;
  }

  .main {
    width: 62.33333%;
  }

  .footer {
    width: 16.66667%;
  }

  body.main-center .main {
    margin-left: 16.66667%;
  }

  body.main-left .sidebar {
    margin-right: 16.66667%;
  }

  body.main-right .sidebar {
    margin-left: 16.66667%;
  }

  body.main-right .main {
    margin-left: 37.66667%;
  }

  body.no-sidebar.main-left .main {
    width: 83.33333333%;
    margin-right: 16.66667%;
  }

  body.no-sidebar.main-right .main,
  body.no-sidebar.main-center .main {
    width: 83.33333333%;
    margin-left: 16.66667%;
  }

  .header #title {
    font-size: 15px;
  }
}

@media (max-width: 1199px) {
  .main-nav > li > a {
    padding: 6px 20px;
  }

  .bar .pager li a span {
    display: none;
  }

  .footer .copyright {
    display: none;
  }
}

@media (max-width: 767px) {
  .navbar-nav .open .dropdown-menu {
    position: static;
    float: none;
    width: auto;
    margin-top: 0;
    background-color: transparent;
    border: 0;
    -webkit-box-shadow: none;
    box-shadow: none;
  }

  .navbar-nav .open .dropdown-menu > li > a,
  .navbar-nav .open .dropdown-menu .dropdown-header {
    padding: 5px 15px 5px 25px;
  }

  .navbar-nav .open .dropdown-menu > li > a {
    line-height: 21px;
  }

  .navbar-nav .open .dropdown-menu > li > a:hover,
  .navbar-nav .open .dropdown-menu > li > a:focus {
    background-image: none;
  }

  .navbar-form .form-group {
    margin-bottom: 5px;
  }

  .navbar-form .form-group:last-child {
    margin-bottom: 0;
  }

  .navbar-default .navbar-nav .open .dropdown-menu > li > a {
    color: #777;
  }

  .navbar-default .navbar-nav .open .dropdown-menu > li > a:hover,
  .navbar-default .navbar-nav .open .dropdown-menu > li > a:focus {
    color: #333;
    background-color: transparent;
  }

  .navbar-default .navbar-nav .open .dropdown-menu > .active > a,
  .navbar-default .navbar-nav .open .dropdown-menu > .active > a:hover,
  .navbar-default .navbar-nav .open .dropdown-menu > .active > a:focus {
    color: #555;
    background-color: #e7e7e7;
  }

  .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a,
  .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:hover,
  .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:focus {
    color: #ccc;
    background-color: transparent;
  }

  .navbar-inverse .navbar-nav .open .dropdown-menu > .dropdown-header {
    border-color: #090909;
  }

  .navbar-inverse .navbar-nav .open .dropdown-menu .divider {
    background-color: #090909;
  }

  .navbar-inverse .navbar-nav .open .dropdown-menu > li > a {
    color: #9d9d9d;
  }

  .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:hover,
  .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:focus {
    color: #fff;
    background-color: transparent;
  }

  .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a,
  .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:hover,
  .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:focus {
    color: #fff;
    background-color: #090909;
  }

  .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a,
  .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:hover,
  .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:focus {
    color: #444;
    background-color: transparent;
  }

  .visible-xs {
    display: block !important;
  }

  table.visible-xs {
    display: table !important;
  }

  tr.visible-xs {
    display: table-row !important;
  }

  th.visible-xs,
  td.visible-xs {
    display: table-cell !important;
  }

  .visible-xs-block {
    display: block !important;
  }

  .visible-xs-inline {
    display: inline !important;
  }

  .visible-xs-inline-block {
    display: inline-block !important;
  }

  .hidden-xs {
    display: none !important;
  }

  body {
    padding-top: 53px;
  }

  .list-circle-num,
  .list-square-num {
    margin: 0 0 40px;
  }

  .modal-xs-full .modal-dialog,
  .modal-xs-full .modal-content {
    height: 100%;
    width: 100%;
    margin: 0;
    border-radius: 0;
    -webkit-box-shadow: none;
    box-shadow: none;
  }

  .modal-xs-full .modal-dialog .donate-box,
  .modal-xs-full .modal-content .donate-box {
    padding-top: 50px;
  }

  .highlight table:before {
    display: block;
    content: ' ';
    height: 38px;
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    margin-left: -10px;
    margin-right: -10px;
    margin-top: -38px;
    background-color: #f6f6f6;
    border-top-left-radius: 4px;
    border-top-right-radius: 4px;
  }

  .header {
    position: fixed;
    left: 0;
    right: 0;
    top: 0;
    width: 100%;
    z-index: 1050;
  }

  .header:before,
  .header:after {
    content: " ";
    display: table;
  }

  .header:after {
    clear: both;
  }

  .sidebar {
    display: none;
  }

  .main {
    min-height: auto;
  }

  .main-nav > li > a {
    padding: 10px 20px;
  }

  .sidebar-form {
    border: 0;
    margin: 9px 45px 9px 0;
  }

  .sidebar-form .input-group-btn .btn {
    color: #2196f3;
  }

  .sidebar-form input[type="text"]:focus {
    background-color: transparent;
  }

  .sidebar-form input[type="text"]:focus + .input-group-btn .btn {
    color: #2196f3;
    background-color: transparent;
  }

  .header .navbar-toggle {
    position: absolute;
    top: 0;
    right: 0;
    margin-right: 5px;
  }

  .header .navbar-toggle .icon-bar {
    width: 18px;
  }

  .header .search {
    width: 90%;
    float: right;
  }

  .header .profile-block {
    padding: 0;
    margin: 10px 0;
    width: 8.33333%;
    float: left;
  }

  .header #avatar {
    width: 32px;
    height: 32px;
  }

  .header #name,
  .header #title,
  .header #location {
    display: none;
  }

  #main-navbar {
    position: absolute;
    width: 100%;
    background-color: #fbfbfb;
    border-bottom: 1px solid #f6f6f6;
    z-index: 99;
  }

  .main .content {
    min-height: auto;
  }

  .sidebar-toc.in {
    position: fixed;
    top: 50px;
    bottom: 50px;
    z-index: 9;
  }

  .bar.bar-footer {
    top: auto !important;
    bottom: 0 !important;
  }

  .footer {
    display: none;
    position: static;
  }

  .footer .copyright {
    display: block;
  }

  .social-links .tooltip {
    display: none !important;
    visibility: hidden;
  }

  .theme-black .search input[type="text"]:focus,
  .theme-blue .search input[type="text"]:focus,
  .theme-green .search input[type="text"]:focus,
  .theme-purple .search input[type="text"]:focus {
    background-color: transparent;
  }

  .theme-black .search input[type="text"]:focus + .input-group-btn .btn,
  .theme-blue .search input[type="text"]:focus + .input-group-btn .btn,
  .theme-green .search input[type="text"]:focus + .input-group-btn .btn,
  .theme-purple .search input[type="text"]:focus + .input-group-btn .btn {
    color: rgba(255, 255, 255, 0.5);
    background-color: transparent;
  }

  .theme-black #main-navbar {
    background: #1a2433;
    background: -webkit-linear-gradient(left, #1a2433 0%, #253449 80%, #253449 100%);
    background: -webkit-gradient(linear, left top, right top, from(#1a2433), color-stop(80%, #253449), to(#253449));
    background: linear-gradient(to right, #1a2433 0%, #253449 80%, #253449 100%);
  }

  .theme-blue #main-navbar {
    background: #0062c5;
    background: -webkit-linear-gradient(left, #0062c5 0%, #0073e6 80%, #0073e6 100%);
    background: -webkit-gradient(linear, left top, right top, from(#0062c5), color-stop(80%, #0073e6), to(#0073e6));
    background: linear-gradient(to right, #0062c5 0%, #0073e6 80%, #0073e6 100%);
  }

  .theme-green #main-navbar {
    background: #08a283;
    background: -webkit-linear-gradient(left, #08a283 0%, #0ac29d 80%, #0ac29d 100%);
    background: -webkit-gradient(linear, left top, right top, from(#08a283), color-stop(80%, #0ac29d), to(#0ac29d));
    background: linear-gradient(to right, #08a283 0%, #0ac29d 80%, #0ac29d 100%);
  }

  .theme-purple #main-navbar {
    background: #494683;
    background: -webkit-linear-gradient(left, #494683 0%, #555299 80%, #555299 100%);
    background: -webkit-gradient(linear, left top, right top, from(#494683), color-stop(80%, #555299), to(#555299));
    background: linear-gradient(to right, #494683 0%, #555299 80%, #555299 100%);
  }
}

@media screen and (max-width: 559px),screen and (max-height: 479px) {
  .ins-search-container {
    top: 0;
    left: 0;
    margin: 0;
    width: 100%;
    height: 100%;
    background: #f7f7f7;
  }
}

@media (max-width: 480px) {
  .header #avatar {
    width: 24px;
    height: 24px;
    margin-top: 3px;
    margin-left: 15px;
  }
}

@media (min-width: 768px) and (max-width: 991px) {
  .visible-sm {
    display: block !important;
  }

  table.visible-sm {
    display: table !important;
  }

  tr.visible-sm {
    display: table-row !important;
  }

  th.visible-sm,
  td.visible-sm {
    display: table-cell !important;
  }

  .visible-sm-block {
    display: block !important;
  }

  .visible-sm-inline {
    display: inline !important;
  }

  .visible-sm-inline-block {
    display: inline-block !important;
  }

  .hidden-sm {
    display: none !important;
  }

  .sidebar-form {
    display: none;
  }

  .header .main-nav > li > a {
    text-align: center;
    padding-left: 0;
    padding-right: 0;
  }

  .header .main-nav > li > a span {
    display: none;
  }

  .header .profile-block {
    padding-top: 10px;
    padding-left: 0;
    padding-right: 0;
  }

  .header #avatar {
    width: 32px;
    height: 32px;
  }

  .footer {
    padding-left: 0;
    padding-right: 0;
  }

  .social-links {
    display: block;
    width: 100%;
    text-align: center;
    margin-bottom: 0;
  }

  .social-links:before,
  .social-links:after {
    content: " ";
    display: table;
  }

  .social-links:after {
    clear: both;
  }

  .social-links li {
    display: block;
    margin-left: 0;
    margin-top: 10px;
  }

  .social-links li:before,
  .social-links li:after {
    content: " ";
    display: table;
  }

  .social-links li:after {
    clear: both;
  }

  .social-links .tooltip {
    display: none !important;
    visibility: hidden;
  }
}

@media (min-width: 992px) and (max-width: 1199px) {
  .visible-md {
    display: block !important;
  }

  table.visible-md {
    display: table !important;
  }

  tr.visible-md {
    display: table-row !important;
  }

  th.visible-md,
  td.visible-md {
    display: table-cell !important;
  }

  .visible-md-block {
    display: block !important;
  }

  .visible-md-inline {
    display: inline !important;
  }

  .visible-md-inline-block {
    display: inline-block !important;
  }

  .hidden-md {
    display: none !important;
  }
}

@media print {
  *,
  *:before,
  *:after {
    background: transparent !important;
    color: #000 !important;
    -webkit-box-shadow: none !important;
    box-shadow: none !important;
    text-shadow: none !important;
  }

  a,
  a:visited {
    text-decoration: underline;
  }

  a[href]:after {
    content: " (" attr(href) ")";
  }

  abbr[title]:after {
    content: " (" attr(title) ")";
  }

  a[href^="#"]:after,
  a[href^="javascript:"]:after {
    content: "";
  }

  pre,
  blockquote {
    border: 1px solid #999;
    page-break-inside: avoid;
  }

  thead {
    display: table-header-group;
  }

  tr,
  img {
    page-break-inside: avoid;
  }

  img {
    max-width: 100% !important;
  }

  p,
  h2,
  h3 {
    orphans: 3;
    widows: 3;
  }

  h2,
  h3 {
    page-break-after: avoid;
  }

  .navbar {
    display: none;
  }

  .btn > .caret,
  .dropup > .btn > .caret {
    border-top-color: #000 !important;
  }

  .label {
    border: 1px solid #000;
  }

  .table {
    border-collapse: collapse !important;
  }

  .table td,
  .table th {
    background-color: #fff !important;
  }

  .table-bordered th,
  .table-bordered td {
    border: 1px solid #ddd !important;
  }

  .visible-print {
    display: block !important;
  }

  table.visible-print {
    display: table !important;
  }

  tr.visible-print {
    display: table-row !important;
  }

  th.visible-print,
  td.visible-print {
    display: table-cell !important;
  }

  .visible-print-block {
    display: block !important;
  }

  .visible-print-inline {
    display: inline !important;
  }

  .visible-print-inline-block {
    display: inline-block !important;
  }

  .hidden-print {
    display: none !important;
  }
}

@media (max-device-width: 480px) and (orientation: landscape) {
  .navbar-fixed-top .navbar-collapse,
  .navbar-fixed-bottom .navbar-collapse {
    max-height: 200px;
  }
}