using System;
using System.Text;
namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Работа с типами
            #region ТИПЫ 
            Console.WriteLine("Пример байтовой переменной, введите символ:");
            byte pbyte = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", pbyte);
            Console.WriteLine("Пример знаковой байтовой переменной, введите символ:");
            sbyte psbyte = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", psbyte);
            Console.WriteLine("Пример буллевой переменной, введите символ:");
            bool pbool = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", pbool);
            Console.WriteLine("Пример символьной переменной, введите символ:");
            char pchar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", pchar);
            Console.WriteLine("Пример краткой числовой переменной, введите символ:");
            short pshort = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", pshort);
            Console.WriteLine("Пример краткой неотрицательной числовой переменной, введите символ:");
            ushort pushort = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", pushort);
            Console.WriteLine("Пример 'валютной' переменной, введите символ:");
            decimal pdecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", pdecimal);
            Console.WriteLine("Пример числовой переменной, введите символ:");
            int pint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", pint);
            Console.WriteLine("Пример неотрицательной числовой переменной, введите символ:");
            uint puint = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", puint);
            Console.WriteLine("Пример числовой переменной с точкой, введите символ:");
            float pfloat = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", pfloat);
            Console.WriteLine("Пример числовой переменной long, введите символ:");
            long plong = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", plong);
            Console.WriteLine("Пример числовой неотрицательной переменной long, введите символ:");
            ulong pulong = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", pulong);
            Console.WriteLine("Пример cтроки, введите строку:");
            string pstring = Console.ReadLine();
            Console.WriteLine("Значиение перемнной: {0}", pstring);
            Console.WriteLine("Пример числовой переменной с плав. точкой, введите символ:");
            double pdouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Значиение перемнной: {0}", pdouble);
            #endregion

            #region Операции Приведения
            Console.WriteLine("Явное приведение:");
            int i1 = 0;
            byte b1 = 12;
            i1 = (int)b1;
            Console.WriteLine("Приведение байта = {0} в инт. Результат: {1}", b1, i1);

            char c1 = 'a';
            i1 = (int)c1;
            Console.WriteLine("Приведение чара = {0} в инт. Результат: {1}", c1, i1);

            i1 = 9;
            byte b2 = (byte)i1;
            Console.WriteLine("Приведение инта = {0} в байт. Результат: {1}", i1, b2);

            double d1 = 12.76;
            i1 = (int)d1;
            Console.WriteLine("Приведение дабла = {0} в инт. Результат: {1}", d1, i1);

            decimal de1 = 1231;
            short s1 = (short)de1;
            Console.WriteLine("Приведение десимал = {0} в шорт. Результат: {1}", de1, s1);

            Console.WriteLine("Неявное приведение");
            int i11 = 0;
            byte b11 = 12;
            i11 = b11;
            Console.WriteLine("Приведение байта = {0} в инт. Результат: {1}", b11, i11);

            char c11 = 'a';
            i11 = c11;
            Console.WriteLine("Приведение чара = {0} в инт. Результат: {1}", c11, i11);

            short b21 = 1234;
            i11 = b21;
            Console.WriteLine("Приведение шорта = {1} в инт. Результат: {0}", i11, b21);

            double d11 = 12.76;
            d11 = i11;
            Console.WriteLine("Приведение инта = {1} в дабл. Результат: {0}", d11, i11);

            decimal de11 = 1231;
            de11 = i11;
            Console.WriteLine("Приведение инта = {0} в десимал. Результат: {1}", i11, de11);
            #endregion

            #region Упаковка
            int pb1 = 123;
            object spb1 = pb1;
            Console.WriteLine("Упаковка инта = {0} в кучу. Результат = {1}", pb1, spb1);
            int pun1 = (int)spb1;
            Console.WriteLine("Распаковка инта = {0} в стек. Результат = {1}", spb1, pun1);
            #endregion

            #region Неявно типизированная переменная
            var pvar1 = 1;
            var pvar2 = "a";
            Console.WriteLine("Неявно типизированная переменная 1 = {0}, неявно типизированная переменная 2 = {1}", pvar1, pvar2);
            #endregion

            #region nullable
            int? pnint1 = null;
            Nullable<int> pnint2 = 7;
            Console.WriteLine("Переменная 1 = {0}, переменная 2 = {1}, переменная 2 знач. = {2}", pnint1, pnint2, pnint2.HasValue);
            #endregion

            #region var
            var primvar = 's';
            primvar = (char)1;
            Console.WriteLine("result = " + primvar);
            #endregion
            #endregion

            Console.WriteLine("--------------------------------------------");

            #region Работа со строками

            #region Сравнение литералов
            string a = "qwerty";
            string b = "qwerty";
            string c = "123456";
            if (a == b) Console.WriteLine("b({0}) равна a({1})", b, a);
            else Console.WriteLine("b({0}) не равна a({1})", b, a);

            if (String.Compare(a, b) == 0) Console.WriteLine("b({0}) равна a({1})", b, a);
            else Console.WriteLine("b({0}) не равна a({1})", b, a);

            if (b == c) Console.WriteLine("b({0}) равна с({1})", b, c);
            else Console.WriteLine("b({0}) не равна с({1})", b, c);
            #endregion

            #region Сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки
            string pstr1 = "Hello world";
            string pstr2 = "+12";
            string pstr4 = "Hello";
            Console.WriteLine("Сцепление: " + pstr1 + pstr2);

            //Console.WriteLine("Копирование: строка 1({0}), строка 2({1}), скопированная во 2 строку({2})", pstr3, pstr2);
            Console.WriteLine("Содержит ли строка '{0}' подстроку '{1}': {2} ", pstr1, pstr4, pstr1.Contains(pstr4));
            string[] cpstr1 = pstr1.Split(' ');
            Console.WriteLine("Первое слово строки pstr1({0}) - {1}, второе - {2}", pstr1, cpstr1[0], cpstr1[1]);
            Console.WriteLine("Вставка строки: 1 строка - {0}, 2 cтрока - {1}, результат - {2}", pstr1, pstr2, pstr1.Insert(5, pstr2));
            int n121 = pstr1.IndexOf(pstr4);
            Console.WriteLine("Удаление подстроки({0}) из строки {1}: {2}", pstr1, pstr4, pstr1.Remove(n121, pstr4.Length));
            #endregion

            #region Пустая и null строки
            string pvstr1 = "";
            string pvstr2 = "\t";
            string pnstr1 = null;
            Console.WriteLine("Пустая ли строка pvstr1:{0}", String.IsNullOrEmpty(pvstr1));
            Console.WriteLine("Пустая ли строка pvstr2:{0}", String.IsNullOrWhiteSpace(pvstr2));
            Console.WriteLine("Null ли строка pvstr1:{0}", String.IsNullOrEmpty(pnstr1));
            #endregion

            #region stringbuilder
            string psstr1 = "some sb string";
            StringBuilder pstrb1 = new StringBuilder(psstr1);
            Console.Write("Удалим 2 - 6 символ строки '{0}'.", pstrb1);
            pstrb1.Remove(2, 3);
            Console.Write(" Результат: {0}", pstrb1);
            Console.Write("\nДобваим символ в строку '{0}'.", pstrb1);
            pstrb1.Insert(2, '4');
            Console.WriteLine(" Результат: {0}", pstrb1);
            #endregion
            #endregion

            Console.WriteLine("--------------------------------------------");


            #region Работа с массивами

            #region Мaтрица
            int[,] parr1 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(parr1[i, j] + " ");
                }
                Console.Write("\n");
            }

            #endregion

            #region Массив строк
            string[] pstrarr1 = { "one ", "two ", "three " };
            for (int i = 0; i < pstrarr1.Length; i++)
            {
                Console.Write(pstrarr1[i]);
            }
            Console.WriteLine("\nДлина массива строк: " + pstrarr1.Length);
            Console.WriteLine("Введите подстроку и позицию(1-3):");
            string chastr = Console.ReadLine()+" ";
            short numb1 = Convert.ToInt16(Console.ReadLine());
            pstrarr1[numb1-1] = chastr;
            Console.WriteLine("Строка с проведенной заменой: ");
            for (int i = 0; i < pstrarr1.Length; i++)
            {
                Console.Write(pstrarr1[i]);
            }
            #endregion

            #region Зубчатый массив
            int[][] ntharr1 = new int[3][];
            ntharr1[0] = new int[2];
            ntharr1[1] = new int[3];
            ntharr1[2] = new int[4];
            int x = 2;
            Console.WriteLine("Введите данные ступенчатого массива:");
            for (int i = 0; i <= 2; i++)
            {

                for (int j = 0; j < x; j++)
                {
                    ntharr1[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                x++;
            }
            x = 2;
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(ntharr1[i][j] + " ");
                }
                x++;
                Console.WriteLine();
            }
            #endregion

            #region Неявно типизированные ...
            var varrp1 = "asd";
            var varrp2 = new object[2];
            varrp2[0] = 1;
            varrp2[1] = 2;
            Console.WriteLine("\nПервая - {0}, вторая - {1}", varrp1, varrp2[1]);
            #endregion
            #endregion

            Console.WriteLine("--------------------------------------------");


            #region Работа с кортежами
            var tuple1 = (int1: 12, string1: "str1", char1: "a", string2: "str2", ulong1: 18446744073709551614);
            var tuple3 = (int1: 12, string1: "str1", char1: "a", string2: "str2", ulong1: 18446744073709551614);
            var tuple2 = (int1: 10, string1: "str1.1", char1: "B", string2: "str2.2", ulong1: 18446744073709551615);
            Console.WriteLine("Содержание кортежа: " + tuple1);
            Console.WriteLine("1, 2 и 5 элементы кортежа: {0}, {1}, {2}", tuple1.int1, tuple1.string1, tuple1.ulong1);
            object objtuple1 = tuple1.char1;
            int inttuple1 = tuple1.int1;
            Console.WriteLine(objtuple1);
            Console.WriteLine(inttuple1);
            if (tuple1 == tuple3) Console.WriteLine("y");
            else Console.WriteLine("n");
            if (tuple1 == tuple2) Console.WriteLine("y");
            else Console.WriteLine("n");
            #endregion

            Console.WriteLine("--------------------------------------------");


            #region Функция main

            int[] a12 = { 1, 2, 3, 4, 5, 6 };
            string str = "str";
            func1(a12, str);
            static (int, int, int, char) func1(int[] a, string b)
            {
                int a1 = a[0];
                int a2 = a[0];
                int a3 = 0;
                char c4 = 'd';
                for (int i = 0; i < a.Length; i++)
                {
                    if (a1 < a[i]) a1 = a[i];
                    if (a2 > a[i]) a2 = a[i];
                    a3 += a[i];
                }
                c4 = b[0];
                Console.WriteLine("минимальный элемент - {0}, максимальный элемент - {1}, сумма - {2}, 1 эл строки - {3}", a1, a2, a3, c4);
                return (a1, a2, a3, c4);
            }
            #endregion

            Console.WriteLine("--------------------------------------------");

            #region checked/uncheked
            funcu1();
            funcu2();
            static void funcu1()
            {
                try {
                    byte a1 = 255;
                    byte a2 = 1;
                    checked
                    {
                        a1 += (byte)a2;
                        Console.WriteLine("checked a1 "+a1);
                    }
                }
                catch
                {
                    Console.WriteLine("Переполнение ");
                }
             }
            static void funcu2()
            {
                try
                {
                    byte a1 = 255;
                    byte a2 = 1;
                    unchecked
                    {
                        a1 += (byte)a2;
                        Console.WriteLine("unchecked a1 "+a1);
                    }
                }
                catch
                {
                    Console.WriteLine("Переполнение");
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
