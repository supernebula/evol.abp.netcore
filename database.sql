/*
Navicat MySQL Data Transfer

Source Server         : 127.0.0.1
Source Server Version : 50726
Source Host           : 127.0.0.1:3306
Source Database       : evol_abp_test

Target Server Type    : MYSQL
Target Server Version : 50726
File Encoding         : 65001

Date: 2020-03-03 20:36:36
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for customer
-- ----------------------------
DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `loginName` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `name` varchar(200) NOT NULL,
  `email` varchar(200) NOT NULL,
  `balance` decimal(10,0) NOT NULL,
  `point` int(11) NOT NULL,
  `createTime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of customer
-- ----------------------------
INSERT INTO `customer` VALUES ('1', 'zhangsan', '111222', '张三', 'zhagnsan@163.com', '101', '10', '2019-12-10 00:20:12');
INSERT INTO `customer` VALUES ('2', 'lisi', '000111', '李四', 'lisi@sina.com', '20', '1', '2019-12-10 09:10:00');
INSERT INTO `customer` VALUES ('4', 'qianqi', '555666', '钱七', 'qianqi@qq.com', '0', '0', '2019-12-10 11:42:58');
INSERT INTO `customer` VALUES ('5', 'liba', '222000', '李八5', 'liba5@qq.com', '0', '0', '2019-12-10 11:45:56');
INSERT INTO `customer` VALUES ('9', 'qishiyi', '444555', '其十一', 'qishiyi@qq.com', '0', '0', '2019-12-10 15:17:37');
