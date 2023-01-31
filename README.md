# FinalWork

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

# Решение задачи

Задаём массив, где колличество элементов и сами элементы пользователь вводит вручную, прописываем блоки ввода и вывода данных на экран (string[] arrayStrings, Console.ReadLine, Console.WriteLine, PrintArray()).

Вводим новую переменную lenght и задаём ему параметр длины элемента. Создаём функцию CheckArray(), которая будет считать элементы, длина которых меньше или равна 3 символам. Полученный результат будем присваивать в переменную smallElements.

Задаём новый массив строк newArrayStrings, который формируется перебором элементов массива arrayStrings, размером равному найденных элементов (lenght = 3 or lenght < 3). Формируем новый массив строк с помощью метода NewArray. И на выходе получается заполненный массив строк newArrayStrings, что является итогом работы программы.