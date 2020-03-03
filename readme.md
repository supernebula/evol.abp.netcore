# Evol.Abp 框架项目ASP.NET Core

基于.NET CORE 3.1 & ABP5。 支持Window2012R2、Linux（Centos7+...）部署

[ABP5.0官方文档](https://aspnetboilerplate.com/Pages/Documents/v5.0.0/)

[aspnetcore-3.1](https://docs.microsoft.com/zh-cn/aspnet/core/getting-started/?view=aspnetcore-3.1&tabs=windows)

[AABP分层架构建议说明](https://www.cnblogs.com/zcc666/articles/11516164.html)



## 解决方案说明

### Evol.Abp.Web.Site 表现层

API、页面

### Evol.Abp.Application  业务逻辑（领域）层

### Evol.Abp.Component  实体层

实体模型、枚举，公用

### Evol.Abp.Data 数据层

集成Dapper 和 EntityFrameworkCore，通过指定DbContext支持多数据连接

### Evol.Abp.Web.Core Web基础设施层

Web公用

### Evol.Abp.Core 基础设施层

框架核心，公用

## 常见问题

[常见问题](issue.md)








