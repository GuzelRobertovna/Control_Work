Итоговая контрольная работа по C#

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Решение:
1. Вначале задаем вручную длину массива (length)
2. Формируем массив str1 длиной length, элементы массива вводим вручную (метод FillArray)
3. Сфрмированный массив выводим на экран (метод PrintArray)
4. Формируем новый массива str2 из элементов первоначального массива, удовлетворяющих условию: длина элементов массива должна быть меньше, либо равна 3 символам (метод GetNewArray)
5. Выводим полученный массив на экран (метод PrintArray)
   