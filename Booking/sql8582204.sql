-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Хост: sql8.freesqldatabase.com
-- Время создания: Дек 06 2022 г., 16:05
-- Версия сервера: 5.5.62-0ubuntu0.14.04.1
-- Версия PHP: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `sql8582204`
--

-- --------------------------------------------------------

--
-- Структура таблицы `booking`
--

CREATE TABLE `booking` (
  `User` varchar(100) NOT NULL,
  `comedate` date NOT NULL,
  `outdate` date NOT NULL,
  `room_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `booking`
--

INSERT INTO `booking` (`User`, `comedate`, `outdate`, `room_id`) VALUES
('', '2022-11-05', '2022-11-12', 1),
('MG', '2022-11-04', '2022-11-12', 1),
('MG', '2022-11-22', '2022-11-29', 1),
('MG', '2022-11-22', '2022-11-29', 1),
('MG', '2022-11-22', '2022-11-29', 1),
('MG', '2022-11-22', '2022-11-29', 1),
('MG', '2022-11-22', '2022-11-29', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `cities`
--

CREATE TABLE `cities` (
  `Name` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `cities`
--

INSERT INTO `cities` (`Name`) VALUES
('Москва'),
('Ульяновск'),
('Санкт-Петербург'),
('Казахстан');

-- --------------------------------------------------------

--
-- Структура таблицы `hotels`
--

CREATE TABLE `hotels` (
  `Name` varchar(40) NOT NULL,
  `City` varchar(40) NOT NULL,
  `Rating` int(11) NOT NULL,
  `Image` varchar(400) NOT NULL,
  `Address` varchar(500) NOT NULL,
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `hotels`
--

INSERT INTO `hotels` (`Name`, `City`, `Rating`, `Image`, `Address`, `ID`) VALUES
('Гостиница \"Космос\"', 'Москва', 5, 'HotelCosmosMOSCOW.jpeg', 'пр-т Мира, 150, Москва, 129366', 1),
('Гостиница \"Азимут\"', 'Санкт-Петербург', 4, 'HotelAzimutSPB.jpg', 'Лермонтовский пр., 43/1, Санкт-Петербург, 190103', 2),
('Гостиница \"Венец\"', 'Ульяновск', 3, 'HotelVenecULSK.jpg', 'Спасская ул., 19/9', 3),
('Гостиница \"Казахстан\"', 'Алматы', 4, 'HotelKazakhstanALMATI.jpg', 'проспект Достык 52/2, Алматы 480051, Казахстан', 4),
('Отель \"Островский\"', 'Кострома', 5, 'HotelOstrovskoyKOSTROMA.jpeg', 'пр. Мира, 4Б, Кострома, Костромская обл., 156000', 5);

-- --------------------------------------------------------

--
-- Структура таблицы `rating`
--

CREATE TABLE `rating` (
  `User` varchar(100) NOT NULL,
  `Hotel_ID` int(11) NOT NULL,
  `Rate` int(11) NOT NULL,
  `Comment` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `rating`
--

INSERT INTO `rating` (`User`, `Hotel_ID`, `Rate`, `Comment`) VALUES
('MG', 1, 9, 'Norm'),
('MG', 1, 1, 'govno vash otel, tarakani vezde'),
('MG', 1, 1, 'govno vash otel, tarakani vezde'),
('MG', 1, 0, '123');

-- --------------------------------------------------------

--
-- Структура таблицы `room contact with hotel`
--

CREATE TABLE `room contact with hotel` (
  `Hotels` varchar(40) NOT NULL,
  `Rooms` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `rooms`
--

CREATE TABLE `rooms` (
  `Name` varchar(50) NOT NULL,
  `Price` varchar(40) NOT NULL,
  `Name_Hotel` varchar(200) NOT NULL,
  `City` varchar(200) NOT NULL,
  `ID` int(11) NOT NULL,
  `Hotel_ID` int(11) NOT NULL,
  `Image` varchar(100) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `rooms`
--

INSERT INTO `rooms` (`Name`, `Price`, `Name_Hotel`, `City`, `ID`, `Hotel_ID`, `Image`, `quantity`) VALUES
('Одноместный, Стандартный номер ', '100', 'Гостиница \"Космос\"', 'Москва', 1, 1, 'DefaultRoomCOSMOS.jpg', 50);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `Name` varchar(20) NOT NULL,
  `Surname` varchar(20) NOT NULL,
  `City` varchar(250) NOT NULL,
  `Age` int(11) NOT NULL,
  `Login` varchar(10) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `ID` int(11) NOT NULL,
  `Admin_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`Name`, `Surname`, `City`, `Age`, `Login`, `Password`, `Email`, `ID`, `Admin_ID`) VALUES
('Марсель', 'Гафуров', 'Ульяновск', 15, 'MG', '123', 'marselch2017@gmail.com', 1, 1),
('Dmitriy', 'Zotov', 'Ульяновск', 16, 'ZotovD', 'ZotovD!', 'zotovd@gmail.com', 2, 0),
('Nikita', 'Konstantinov', 'Ульяновск', 16, 'NKosnt', 'NikitaKonst', 'Konstantinov@gmail.com', 3, 0);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `hotels`
--
ALTER TABLE `hotels`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `hotels`
--
ALTER TABLE `hotels`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT для таблицы `rooms`
--
ALTER TABLE `rooms`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
