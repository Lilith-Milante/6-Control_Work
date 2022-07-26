# Задача для контрольной

* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
* При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Ход работы

1. создаём удалённый репозиторий на GitHub и связываем с его с локальным;
2. обзаводимся тем, что нужно для работы:
     * файл gitignore
     * блок-схема
     * папка с программой, там будет код
     * файл readme
3. делаем первые записи в файле readme для удобства;
4. делаем блок-схему;
5. пишем код; какова концепция решения:
  * задаём первый строковый массив
  * создаём второй строковый массив, куда будем вносить нужные элементы из первого
  * основной метод: метод, в котором проверяется условие, по которому элементы из первого массива попадают во второй массив
    * метод работает, пока мы не переберём все элементы первого массива, то есть пока i > длины первого массива, i - счётчик как и всегда - это условие описывает цикл for
    * сталкиваясь с каждым элементом первого массива, проверяем его по условию <= 3
    * вводим переменную count, которая будет забирать проходящие по условию элементы в новый массив, выглядит это как присваивание вида count = [i]
    * увеличиваем count на 1, чтобы двигаться к следущему элементу нового массива
  * печатаем массив; нас интересует второй

Структура файла с программой:
 * Первые несколько строк - операции, сам код
 * Далее - 2 метода (основной и печати)