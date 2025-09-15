-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema gerenciamento
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema gerenciamento
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `gerenciamento` DEFAULT CHARACTER SET utf8 ;
#create database gerenciamento;
USE `gerenciamento` ;

-- -----------------------------------------------------
-- Table `gerenciamento`.`produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gerenciamento`.`produto` (
  `cod_produto` INT NOT NULL,
  `nome` VARCHAR(45) NULL,
  `quantidade` INT NULL,
  `preco` DECIMAL(5,2) NULL,
  `marca` VARCHAR(45) NULL,
  `modelo` VARCHAR(45) NULL,
  `foto` VARCHAR(45) NULL,
  `observacao` VARCHAR(45) NULL,
  PRIMARY KEY (`cod_produto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gerenciamento`.`funcionario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gerenciamento`.`funcionario` (
  `cod_funcionario` INT NOT NULL,
  `nome` VARCHAR(45) NULL,
  `cargo` VARCHAR(45) NULL,
  `data_admissao` DATE NULL,
  `salario` DECIMAL(5,2) NULL,
  `email` VARCHAR(45) NULL,
  `funcionariocol` VARCHAR(45) NULL,
  PRIMARY KEY (`cod_funcionario`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gerenciamento`.`financeiro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gerenciamento`.`financeiro` (
  `cod_financeiro` INT NOT NULL,
  `descricao` VARCHAR(45) NULL,
  `valor` DECIMAL(5,2) NULL,
  `tipo` VARCHAR(45) NULL,
  `servico` VARCHAR(45) NULL,
`data_lancamento` date NULL,
  `pgto` boolean NULL,

  PRIMARY KEY (`cod_financeiro`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `gerenciamento`.`cargo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gerenciamento`.`cargo` (
  `cod_cargo` INT NOT NULL,
  `cargo` VARCHAR(45) NULL,
  PRIMARY KEY (`cod_cargo`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
