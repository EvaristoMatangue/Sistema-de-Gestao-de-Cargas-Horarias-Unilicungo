-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Jun-2025 às 09:45
-- Versão do servidor: 10.4.32-MariaDB
-- versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cargas_horarias_unilicungo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `chefedepartamento`
--

CREATE TABLE `chefedepartamento` (
  `id` int(11) NOT NULL,
  `telefone` varchar(20) DEFAULT current_timestamp(),
  `nome` varchar(80) NOT NULL,
  `email` varchar(100) NOT NULL,
  `nomeusuario` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `chefedepartamento`
--

INSERT INTO `chefedepartamento` (`id`, `telefone`, `nome`, `email`, `nomeusuario`) VALUES
(8, '876253739', 'Egas Frederico Lemos', 'egaslemos@gmail.com', 'egaslemos');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cursos`
--

CREATE TABLE `cursos` (
  `ID` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `cordenadorID` int(11) DEFAULT NULL,
  `periodo` varchar(50) DEFAULT NULL,
  `Nivel` varchar(30) DEFAULT NULL,
  `cordenador` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `cursos`
--

INSERT INTO `cursos` (`ID`, `Nome`, `cordenadorID`, `periodo`, `Nivel`, `cordenador`) VALUES
(26, 'Informatica', NULL, 'Laboral', '3º Ano', 'Evaristo Joaquim Matangue'),
(27, 'Biologia', NULL, 'Pos-Laboral', '4º Ano', 'Jose Adriano'),
(29, 'Matematica', NULL, 'Pos-Laboral', '2º Ano', 'Pedro Mateus'),
(30, 'sdad', NULL, 'Pos-Laboral', '2º Ano', 'Joao Faquira'),
(31, 'Agronomia', 23, 'Pos-Laboral', '2º Ano', 'Abdul Cadre'),
(32, 'EGI', NULL, 'Laboral', '2º Ano', NULL),
(35, 'Quimica', NULL, 'Laboral', '3º Ano', NULL),
(36, 'Fisica', NULL, 'Laboral', '1º Ano', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `disciplinas`
--

CREATE TABLE `disciplinas` (
  `ID` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `CargaHoraria` int(11) NOT NULL,
  `Nivel` varchar(10) NOT NULL,
  `CursoID` int(11) DEFAULT NULL,
  `Semestre` varchar(30) NOT NULL,
  `curso` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `disciplinas`
--

INSERT INTO `disciplinas` (`ID`, `Nome`, `CargaHoraria`, `Nivel`, `CursoID`, `Semestre`, `curso`) VALUES
(32, 'Programacao Imperativa', 6, '3º Ano', 26, '1º Semestre', 'Informatica'),
(33, 'Sistema Operacional', 4, '1º Ano', 26, '2º Semestre', 'Informatica'),
(34, 'Lab1', 4, '1º Ano', 26, '2º Semestre', 'Informatica'),
(35, 'Investigacao operacional', 4, '3º Ano', 29, '1º Semestre', 'Matematica'),
(36, 'Informatica Basica', 5, '3º Ano', 27, '1º Semestre', 'Biologia'),
(38, 'MateFisica', 3, '2º Ano', 27, '2º Semestre', 'Biologia'),
(39, 'Lab2', 6, '2º Ano', 29, '1º Semestre', 'Matematica'),
(40, 'Metafisica', 2, '2º Ano', 31, '1º Semestre', 'Agronomia'),
(41, 'Programacao em C#', 4, '4º Ano', 26, '1º Semestre', 'Informatica'),
(42, 'Tecnologias Multi-Medias', 2, '3º Ano', 26, '2º Semestre', 'Informatica'),
(43, 'Redes de Computadores', 4, '3º Ano', 26, '1º Semestre', 'Informatica'),
(44, 'Estrutura de dados e Algoritimos', 4, '1º Ano', 26, '2º Semestre', 'Informatica'),
(45, 'Jornalismo', 2, '2º Ano', 32, '1º Semestre', 'EGI'),
(46, 'Servicos De direitos', 6, '2º Ano', 26, '1º Semestre', 'Informatica');

-- --------------------------------------------------------

--
-- Estrutura da tabela `docentes`
--

CREATE TABLE `docentes` (
  `ID` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `Curso` varchar(100) NOT NULL,
  `nivelacademico` varchar(50) NOT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Telefone` varchar(30) DEFAULT NULL,
  `Nomeusuario` varchar(30) DEFAULT NULL,
  `numcarga` int(11) DEFAULT NULL,
  `Observacao` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `docentes`
--

INSERT INTO `docentes` (`ID`, `Nome`, `Curso`, `nivelacademico`, `Email`, `Telefone`, `Nomeusuario`, `numcarga`, `Observacao`) VALUES
(26, 'Joao Faquira', 'Informatica', 'Licenciado', 'faquira91@gmail.com', '876476434', 'jfaquira', 16, ''),
(27, 'Jose Adriano', 'Biologia', 'Licenciado', 'jadriano@gmail.com', '876456334', 'jadriano', 16, 'Bolsa Parcial'),
(28, 'Pedro Mateus', 'Matematica', 'Licenciado', 'pmateus@gmail.com', '875374576', 'pmateus', 16, ''),
(29, 'Abdul Cadre', 'Informatica', 'Mestrado', 'acadre@gmail.com', '879283938', 'acadre', 12, ''),
(30, 'Maria de Souza', 'Biologia', 'Mestrado', 'msouza@gmail.com', '862923933', 'msouza', 12, ''),
(31, 'Ivanilton Andrade', 'Informatica', 'PHD', 'ivanilton@gmail.com', '876556633', 'iandrade', 8, ''),
(32, 'Manuel Jose', 'Fisica', 'Licenciado', 'mjose@gmail.com', '876453535', 'mjose', 16, 'Nomeado Recentemente'),
(33, 'Evaristo Joaquim Matangue', 'Informatica', 'Mestrado', 'evaristojoa99@gmail.com', '876593745', 'emandaraza', 12, 'Renomeado Recentemente');

-- --------------------------------------------------------

--
-- Estrutura da tabela `gestorescurso`
--

CREATE TABLE `gestorescurso` (
  `ID` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `email` varchar(30) DEFAULT NULL,
  `telefone` varchar(30) DEFAULT NULL,
  `cursoID` int(11) NOT NULL,
  `nomeusuario` varchar(50) NOT NULL,
  `curso` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `gestorescurso`
--

INSERT INTO `gestorescurso` (`ID`, `Nome`, `email`, `telefone`, `cursoID`, `nomeusuario`, `curso`) VALUES
(20, 'Jose Adriano', 'jadriano@gmail.com', '876456334', 27, 'jadriano', 'Biologia'),
(22, 'Joao Faquira', 'jfaquira@gmail.com', '876476434', 30, 'jfaquira', 'sdad'),
(23, 'Ivanilton Andrade', 'dslksfdf@hjfd.sdc', '876556633', 31, 'iandrade', 'mmmm'),
(24, 'Abdul Cadre', 'acadre@gmail.com', '879283938', 31, 'acadre', 'Agronomia'),
(25, 'Evaristo Joaquim Matangue', 'evaristojoa99@gmail.com', '876593745', 26, 'emandaraza', 'Informatica');

-- --------------------------------------------------------

--
-- Estrutura da tabela `gestoresrh`
--

CREATE TABLE `gestoresrh` (
  `ID` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `email` varchar(30) DEFAULT NULL,
  `telefone` varchar(30) DEFAULT NULL,
  `nomeusuario` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `gestoresrh`
--

INSERT INTO `gestoresrh` (`ID`, `Nome`, `email`, `telefone`, `nomeusuario`) VALUES
(4, 'Joaquim Mandaraza', 'jmandaraza@gmail.com', '861695907', 'jmandaraza');

-- --------------------------------------------------------

--
-- Estrutura da tabela `mensagens`
--

CREATE TABLE `mensagens` (
  `id` int(11) NOT NULL,
  `nomedestinatario` varchar(80) NOT NULL,
  `remetente_id` int(11) DEFAULT NULL,
  `destinatario_id` int(11) DEFAULT NULL,
  `assunto` varchar(100) DEFAULT NULL,
  `conteudo` text DEFAULT NULL,
  `dataemissao` datetime DEFAULT current_timestamp(),
  `lida` tinyint(1) DEFAULT 0,
  `nomeemissor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `turmas`
--

CREATE TABLE `turmas` (
  `id` int(11) NOT NULL,
  `nomedisciplina` varchar(100) DEFAULT NULL,
  `cursoid` int(11) DEFAULT NULL,
  `curso` varchar(80) NOT NULL,
  `semestre` int(11) DEFAULT NULL,
  `anoletivo` year(4) DEFAULT NULL,
  `docente` varchar(80) NOT NULL,
  `regime` varchar(30) NOT NULL,
  `ano` varchar(20) NOT NULL,
  `cargahoraria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `turmas`
--

INSERT INTO `turmas` (`id`, `nomedisciplina`, `cursoid`, `curso`, `semestre`, `anoletivo`, `docente`, `regime`, `ano`, `cargahoraria`) VALUES
(1, 'Programacao Imperativa', 26, 'Informatica', 1, '2025', 'Joao Faquira', 'Laboral', '2º Ano', 6),
(2, 'Sistema Operacional', 26, 'Informatica', 1, '2025', 'Evaristo Joaquim Mandaraza', 'Pos-Laboral', '2º Ano', 4),
(6, 'Sistema Operacional', 29, 'Matematica', 1, '2025', 'Ivanilton Andrade', 'Laboral', '2º Ano', 4),
(7, 'Sistema Operacional', 29, 'Matematica', 2, '2025', 'Joao Faquira', 'Laboral', '2º Ano', 4),
(8, 'Investigacao operacional', 31, 'Agronomia', 1, '2025', 'Jose Adriano', 'Laboral', '1º Ano', 4),
(12, 'Lab2', NULL, 'Matematica', 1, '2025', 'Abdul Cadre', 'Laboral', '2º Ano', 6),
(14, 'Programacao Imperativa', NULL, 'Informatica', 1, '2025', 'Maria de Souza', 'Pos-Laboral', '3º Ano', 6),
(16, 'Informatica Basica', NULL, 'Biologia', 1, '2025', 'Maria de Souza', 'Pos-Laboral', '3º Ano', 5),
(18, 'Programacao em C#', NULL, 'Informatica', 1, '2025', 'Joao Faquira', 'Laboral', '4º Ano', 4),
(19, 'Servicos De direitos', NULL, 'Informatica', 1, '2025', 'Joao Faquira', 'Laboral', '2º Ano', 6);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nomeusuario` varchar(100) NOT NULL,
  `senha` varchar(225) NOT NULL,
  `tipousuario` varchar(50) NOT NULL,
  `email` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nomeusuario`, `senha`, `tipousuario`, `email`) VALUES
(25, 'jmandaraza', '$2a$11$RRK9hsdzQS.aU8.vBhH0COVffyv2UbJa.Gc3lojQ.GcD3W/iSgBAO', 'gestorrh', 'evristojoa99@gmail.com'),
(36, 'jfaquira', '$2a$11$U.2kZ9.s2WisHpfUpgMevuhfMk3r1fZRtU1AxtuFFisQ2OCggfiju', 'gestorcurso', 'faquira91@gmail.com'),
(37, 'jadriano', '$2a$11$qt4ZGjTs3nN1gqLwjy641OYfGS55JBLA.lhOl04yMzQneC90EKE52', 'gestorcurso', 'jadriano@gmail.com'),
(38, 'pmateus', '$2a$11$6DsesCr5t7qjwxgLofiF7eK7FySeA.zxYb/zTbZ1uv079H592QOv.', 'docente', 'pmateus@gmail.com'),
(39, 'acadre', '$2a$11$GfhBodZ3BEjwUOqAoBP5serRPsINMtR/fmhz9HsrSQRRuPilyjCB2', 'gestorcurso', NULL),
(40, 'egaslemos', '$2a$11$F2FOE.apzVvFjPDR9FkrwuDit2UQoRfOdKUgleDYDLLkYt.GDK.0G', 'chefedepartamento', 'egaslemos@gmail.com'),
(41, 'msouza', '$2a$11$JNrQZHtaEQa3QgPY0EHMEOJ.o5l4dJnYodC8RDXmXJ6xF3tKVNlOW', 'docente', 'msouza@gmail.com'),
(42, 'iandrade', '$2a$11$c2OfFnEw.aRONjLL7eL0AetOjt9yTWCKtH8ap3/NZeXnKqqamqjSa', 'gestorcurso', 'ivanilton@gmail.com'),
(43, 'mjose', '$2a$11$B8t7OR1ypFKAFx13GpEY1OLc0nedFMPZ9mowX800rO4sHaAbAmQG2', 'docente', NULL),
(44, 'emandaraza', '$2a$11$Nn9lt9kDSco3taZgmaqGgOX5exW2N2hd9O.NdblxKzi1LZFYF4AOK', 'gestorcurso', 'evaristojoa99@gmail.com');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `chefedepartamento`
--
ALTER TABLE `chefedepartamento`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `cursos`
--
ALTER TABLE `cursos`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `disciplinas`
--
ALTER TABLE `disciplinas`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `docentes`
--
ALTER TABLE `docentes`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Nomeusuario` (`Nomeusuario`);

--
-- Índices para tabela `gestorescurso`
--
ALTER TABLE `gestorescurso`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `nomeusuario` (`nomeusuario`);

--
-- Índices para tabela `gestoresrh`
--
ALTER TABLE `gestoresrh`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `nomeusuario` (`nomeusuario`);

--
-- Índices para tabela `mensagens`
--
ALTER TABLE `mensagens`
  ADD PRIMARY KEY (`id`),
  ADD KEY `remetente_id` (`remetente_id`),
  ADD KEY `destinatario_id` (`destinatario_id`);

--
-- Índices para tabela `turmas`
--
ALTER TABLE `turmas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `curso_id` (`cursoid`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nomeusuario` (`nomeusuario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `chefedepartamento`
--
ALTER TABLE `chefedepartamento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `cursos`
--
ALTER TABLE `cursos`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT de tabela `disciplinas`
--
ALTER TABLE `disciplinas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT de tabela `docentes`
--
ALTER TABLE `docentes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT de tabela `gestorescurso`
--
ALTER TABLE `gestorescurso`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de tabela `gestoresrh`
--
ALTER TABLE `gestoresrh`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `mensagens`
--
ALTER TABLE `mensagens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `turmas`
--
ALTER TABLE `turmas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `mensagens`
--
ALTER TABLE `mensagens`
  ADD CONSTRAINT `mensagens_ibfk_1` FOREIGN KEY (`remetente_id`) REFERENCES `usuarios` (`id`),
  ADD CONSTRAINT `mensagens_ibfk_2` FOREIGN KEY (`destinatario_id`) REFERENCES `usuarios` (`id`);

--
-- Limitadores para a tabela `turmas`
--
ALTER TABLE `turmas`
  ADD CONSTRAINT `turmas_ibfk_1` FOREIGN KEY (`cursoid`) REFERENCES `cursos` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
