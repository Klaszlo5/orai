--1.
CREATE DATABASE papirgyujtes CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;

-- 3. 
SELECT t.nev, t.osztaly, l.idopont, l.mennyiseg
FROM tanulok t
JOIN leadasok l ON t.tazon = l.tanulo
WHERE t.osztaly = '1A' OR t.osztaly = '1B' OR t.osztaly = '1C' -- Mivel az 1. osztályosok bármely osztályt jelölhetnek, meg kell adni a lehetséges 1. osztályokat
ORDER BY l.idopont;

-- 4.
SELECT idopont, AVG(mennyiseg) AS `napi atlag`
FROM leadasok
GROUP BY idopont
HAVING idopont IN ('2016-10-03', '2016-10-05', '2016-10-07');

-- 5. felad
SELECT DISTINCT osztaly
FROM tanulok t
JOIN leadasok l ON t.tazon = l.tanulo
WHERE l.idopont = '2016-10-28'
ORDER BY osztaly;

-- 6.
SELECT t.osztaly, SUM(l.mennyiseg) / 10000 AS mazsa
FROM tanulok t
JOIN leadasok l ON t.tazon = l.tanulo
GROUP BY t.osztaly
ORDER BY SUM(l.mennyiseg) DESC;

-- 7. 
SELECT t.nev, t.osztaly, SUM(l.mennyiseg) AS osszesen
FROM tanulok t
JOIN leadasok l ON t.tazon = l.tanulo
GROUP BY t.tazon
ORDER BY osszesen DESC
LIMIT 10;