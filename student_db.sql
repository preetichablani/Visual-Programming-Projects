-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2026 at 08:38 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `student_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `citydetail`
--

CREATE TABLE `citydetail` (
  `city_id` int(11) NOT NULL,
  `city_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `citydetail`
--

INSERT INTO `citydetail` (`city_id`, `city_name`) VALUES
(1, 'Ajmer'),
(2, 'Jaipur'),
(3, 'Kota'),
(4, 'Bikaner'),
(5, 'Jodhpur');

-- --------------------------------------------------------

--
-- Table structure for table `classdetail`
--

CREATE TABLE `classdetail` (
  `class_id` int(11) NOT NULL,
  `class_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `classdetail`
--

INSERT INTO `classdetail` (`class_id`, `class_name`) VALUES
(1, 'BCA 1 Year'),
(2, 'BCA 2 Year'),
(3, 'BCA 3 Year');

-- --------------------------------------------------------

--
-- Table structure for table `student_info`
--

CREATE TABLE `student_info` (
  `autoid` int(11) NOT NULL,
  `stud_id` varchar(10) NOT NULL,
  `stud_name` varchar(30) NOT NULL,
  `stud_class` varchar(20) NOT NULL,
  `stud_city` varchar(20) NOT NULL,
  `stud_pno` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_info`
--

INSERT INTO `student_info` (`autoid`, `stud_id`, `stud_name`, `stud_class`, `stud_city`, `stud_pno`) VALUES
(1, 'STU0001', 'Tarun Sharma', 'BCA 3 Year', 'Kota', '9852541458'),
(2, 'STU0002', 'Harshita Varma', 'BCA 2 Year', 'Kota', '8525485965'),
(4, 'STU0003', 'Pooja Kumari', 'BCA 2 Year', 'Kota', '8545848754');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `citydetail`
--
ALTER TABLE `citydetail`
  ADD PRIMARY KEY (`city_id`);

--
-- Indexes for table `classdetail`
--
ALTER TABLE `classdetail`
  ADD PRIMARY KEY (`class_id`);

--
-- Indexes for table `student_info`
--
ALTER TABLE `student_info`
  ADD PRIMARY KEY (`autoid`,`stud_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `citydetail`
--
ALTER TABLE `citydetail`
  MODIFY `city_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `classdetail`
--
ALTER TABLE `classdetail`
  MODIFY `class_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `student_info`
--
ALTER TABLE `student_info`
  MODIFY `autoid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
