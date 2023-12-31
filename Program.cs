﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Net.NetworkInformation;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

public class Program
{
	public static void Main(string[] args)
	{
		//____________________________________________Summator_______________________________________________
		/*
		A.Сумматор(5 баллов)
ограничение по времени на тест3 секунды
ограничение по памяти на тест256 мегабайт
вводстандартный ввод
выводстандартный вывод

Напишите программу, которая выводит сумму двух целых чисел.

Входные данные
В первой строке входных данных содержится целое число t
 (1≤t≤104) — количество наборов входных данных в тесте.
Далее следуют описания t
 наборов входных данных, один набор в строке.
В первой(и единственной) строке набора записаны два целых числа a
 и b
 (−1000≤a, b≤1000).

Выходные данные
Для каждого набора входных данных выведите сумму двух заданных чисел, то есть a+b.
*/
		//Summator();
		//___________________________________________Sum for pay_____________________________________________
		/*
		B. Сумма к оплате (10 баллов)
ограничение по времени на тест1 секунда
ограничение по памяти на тест256 мегабайт
вводстандартный ввод
выводстандартный вывод

В магазине акция: «купи три одинаковых товара и заплати только за два». Конечно, каждый купленный товар может участвовать лишь в одной акции. Акцию можно использовать многократно. Считая, что одинаковые цены имеют только одинаковые товары, найдите сумму к оплате.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

Входные данные
В первой строке записано целое число t
 (1≤t≤104) — количество наборов входных данных.
Далее записаны наборы входных данных. Каждый начинается строкой, которая содержит n
 (1≤n≤2⋅105) — количество купленных товаров. Следующая строка содержит их цены p1,p2,…,pn
 (1≤pi≤104). Если цены двух товаров одинаковые, то надо считать, что это один и тот товар.
Гарантируется, что сумма значений n по всем тестам не превосходит 2⋅105.

Выходные данные
Выведите t целых чисел — суммы к оплате для каждого из наборов входных данных.
		*/
		//SumForPay();
		//_________________________________________Pair programming__________________________________________
		/*
		C. Парное программирование (10 баллов)
ограничение по времени на тест1 секунда
ограничение по памяти на тест512 мегабайт
вводстандартный ввод
выводстандартный вывод

В компании работает n разработчиков, где n — четное число. Сумасшедший менеджер решил разбить всех разработчиков на команды по два
человека. Для этого он составил список всех разработчиков и назначил каждому из них номер по списку (от 1 до n) и значение ai — уровень мастерства i-го в списке разработчика.
Очередную команду он составляет следующим образом:
первый разработчик в команде тот, кто идет первым в списке;
ему в пару подбирается такой, что разница их уровней минимальна (то есть минимально значение |ai−aj|, где |x| — это модуль числа x);
если таких кандидатов несколько, то выбирается из них тот, кто находится раньше в списке;
эти два разработчика образуют команду и удаляются из списка.
Ваша задача — помочь сумасшедшему менеджеру промоделировать процесс разбиения на команды. Обратите внимание, что команды должны быть выведены в порядке, описанном выше в условии.

Входные данные
Первая строка содержит одно целое число t
 (1≤t≤50) — количество наборов входных данных.
Первая строка каждого набора содержит одно целое число n
 (2≤n≤50; n четное) — количество разработчиков.
Вторая строка содержит n целых чисел a1,a2,…,an (1≤ai≤100), где ai — уровень мастерства i-го разработчика.

Выходные данные
Для каждого набора входных данных выведите n2 строк, i-я строка должна содержать пару чисел — номер первого и второго разработчика в i-й команде в порядке, описанном в условии.

Выводите пустую строку между выводами для наборов входных данных.
		*/
		//PairProgramming();
		//________________________________________Electronic matrix__________________________________________
		/*
		D. Электронная таблица (10 баллов)
ограничение по времени на тест1 секунда
ограничение по памяти на тест256 мегабайт
вводстандартный ввод
выводстандартный вывод

Вам необходимо написать часть функциональности обработки сортировок в электронных таблицах.
Задана прямоугольная таблица n×m (n строк по m столбцов) из целых чисел.
Если кликнуть по заголовку i-го столбца, то строки таблицы пересортируются таким образом, что в этом столбце значения будут идти по неубыванию (то есть возрастанию или равенству). При этом, если у двух строк одинаковое значение в этом столбце, то относительный порядок строк не изменится.
Обработайте последовательность кликов и выведите состояние таблицы после всех кликов.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

Входные данные
В первой строке записано целое число t (1≤t≤100) — количество наборов входных данных в файле. Далее следуют описания наборов, перед каждым из них записана пустая строка.
В первой строке набора записаны два целых числа n и m (1≤n,m≤30) — количество строк и столбцов в таблице.
Далее следуют n строк по m целых чисел в каждой — начальное состояние таблицы. Все элементы таблицы от 1 до 100.
Затем входные данные содержат строку с один целым числом k (1≤k≤30) — количество кликов.
Следующая строка содержит k целых чисел c1,c2,…,ck (1≤ci≤m) — номера столбцов, по которым были осуществлены клики. Клики даны в порядке их совершения.

Выходные данные
Для каждого набора входных данных выведите n строк по m чисел в каждой — итоговое состояние таблицы. После каждого набора выходных данных выводите дополнительный перевод строки.
		*/
		//ElectronicMatrix();
		//__________________________________________Task scheduler____________________________________________
		/*
		I. Планировщик задач (30 баллов)
ограничение по времени на тест3 секунды
ограничение по памяти на тест256 мегабайт
вводстандартный ввод
выводстандартный вывод

Представьте, вы собрали собственный сервер из n разнородных процессоров и теперь решили создать для него простейший планировщик задач.
Ваш сервер состоит из n процессоров. Но так как процессоры разные, то и достигают они одинаковой скорости работы при разном энергопотреблении. А именно, i-й процессор в нагрузке тратит ai энергии за одну секунду.
Вашему серверу в качестве тестовой нагрузки придет m задач. Про каждую задачу вам известны два значения: tj и lj — момент времени, когда задача j придет и время выполнения задачи в секундах.
Для начала вы решили реализовать простейший планировщик, ведущий себя следующим образом: в момент tj прихода задачи, вы выбираете свободный процессор с минимальным энергопотреблением и выполняете данную задачу на выбранном процессоре все заданное время. Если к моменту прихода задачи свободных процессоров нет, то вы просто отбрасываете задачу.
Процессор, на котором запущена задача j будет занят ровно lj секунд, то есть освободится ровно в момент tj+lj и в этот же момент уже может быть назначен для выполнения какой-то другой задачи.
Определите суммарное энергопотребление вашего сервера при обработке m заданных задач (будем считать, что процессоры в простое не потребляют энергию).

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

Входные данные
В первой строке заданы два целых числа n и m (1≤n,m≤3⋅105) — количество процессоров и задач соответственно.
Во второй строке заданы n целых чисел a1,a2,…,an (1≤ai≤106) — энергопотребление соответствующих процессоров под нагрузкой в секунду. Все энергопотребления различны.
В следующих m строках заданы описания задач: по одному в строке. В j-й строке заданы два целых числа tj и lj (1≤tj≤109; 1≤lj≤106)—момент прихода j-й задачи и время ее выполнения.

Все времена прихода tj различны, и задачи заданы в порядке времени прихода.

Выходные данные
Выведите единственное число — суммарное энергопотребление сервера, если потреблением энергии в простое можно пренебречь.
		*/
		//MyTaskShelduler();
		//______________________________________________Report________________________________________________
		/*
		E. Отчет (15 баллов)
ограничение по времени на тест2 секунды
ограничение по памяти на тест512 мегабайт
вводстандартный ввод
выводстандартный вывод

Директор IT-корпорации оценивает эффективность работы сотрудников по различным показателям и критериям. Один из этих критериев сформулирован следующим образом: приступив к некоторому заданию, сотрудник должен завершить его, не переключаясь на другие задания.
Чтобы проверить сотрудников на соответствие этому критерию, директор потребовал от каждого сотрудника отчет о том, какие задания он выполнял в последние n дней. Отчет — это последовательность из n целых чисел a1,a2,…,an, где ai — идентификатор задания, которое сотрудник выполнял в i-й день.
Вам необходимо написать программу, проверяющую, соответствует ли сотрудник критерию по его отчету. Сотрудник соответствует этому критерию, если не существует такого задания x, которое выполнялось с перерывом (т. е. в некоторый день i сотрудник выполнял задание x, в дни с i+1 по j−1 он занимался другими заданиями, а в день j сотрудник продолжил выполнение задания x, при этом j>i+1). Иными словами,каждое задание, которое выполнял сотрудник, должно занимать один непрерывный отрезок дней.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

Входные данные
В первой строке задано одно целое число t (1≤t≤10) — количество наборов входных данных.
Каждый набор входных данных состоит из двух строк. В первой строке задано одно целое число n (3≤n≤50000). 
Во второй строке заданы n целых чисел a1,a2,…,an (1≤ai≤n) — отчет сотрудника.

Выходные данные
Для каждого набора входных данных выведите ответ на отдельной строке. Если отчет соответствует критерию, выведите YES, иначе выведите NO.
		*/
		//Report();
		//__________________________________________Periods of time___________________________________________
		/*
		F. Отрезки времени (20 баллов)
ограничение по времени на тест2 секунды
ограничение по памяти на тест512 мегабайт
вводстандартный ввод
выводстандартный вывод

Вам задан набор отрезков времени. Каждый отрезок задан в формате HH:MM:SS-HH:MM:SS, то есть сначала заданы часы, минуты и секунды левой границы отрезка, а затем часы, минуты и секунды правой границы.
Вам необходимо выполнить валидацию заданного набора отрезков времени. Иными словами, вам нужно проверить следующие условия:
часы, минуты и секунды заданы корректно (то есть часы находятся в промежутке от 0 до 23, а минуты и секунды — в промежутке от 0 до 59);
левая граница отрезка находится не позже его правой границы (но границы могут быть равны);
никакая пара отрезков не пересекается (даже в граничных моментах времени).
Вам необходимо вывести YES, если заданный набор отрезков времени проходит валидацию, и NO в противном случае.

Вам необходимо ответить на t независимых наборов тестовых данных.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

Входные данные
Первая строка входных данных содержит одно целое число t (1≤t≤10) — количество наборов тестовых данных. Затем следуют t наборов.
Первая строка набора содержит одно целое число n (1≤n≤2⋅104) — количество отрезков времени. В следующих n строках следуют описания отрезков.

Описание отрезка времени задано в формате HH:MM:SS-HH:MM:SS, где HH, MM и SS — последовательности из двух цифр. Заметьте, что никаких пробелов в описании формата нет. Также ни в одном описании нет пробелов в начале и конце строки.

Выходные данные
Для каждого набора тестовых данных выведите ответ — YES, если заданный набор отрезков времени проходит валидацию, и NO в противном случае. Ответы выводите в порядке следования наборов во входных данных.
		*/
		//PeriodsOfTime();
		//_____________________________________________Max rhyme______________________________________________
		/*
		J. Рифмы (30 баллов)
ограничение по времени на тест2 секунды
ограничение по памяти на тест512 мегабайт
вводстандартный ввод
выводстандартный вывод

Вы разрабатываете программу автоматической генерации стихотворений. Один из модулей этой программы должен подбирать рифмы к словам из некоторого словаря.
Словарь содержит n различных слов. Словами будем называть последовательности из 1—10 строчных букв латинского алфавита.
Зарифмованность двух слов — это длина их наибольшего общего суффикса (суффиксом будем называть какое-то количество букв в конце слова). 
Ваша программа должна обработать q запросов следующего вида: дано слово ti (возможно, принадлежащее словарю), необходимо найти слово из словаря, которое не совпадает с ti и имеет максимальную зарифмованность с ti среди всех слов словаря, не совпадающих с ti. Если подходящих слов несколько — выведите любое из них.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

Входные данные
Первая строка содержит одно целое число n (2≤n≤50000) — размер словаря.
Далее следуют n строк, i-я строка содержит одну строку si (1≤|si|≤10) — i-е слово из словаря. В словаре все слова различны.
Следующая строка содержит одно целое число q (1≤q≤50000) — количество запросов.
Далее следуют q строк, i-я строка содержит одну строку ti (1≤|ti|≤10) — i-й запрос.
Каждая строка si и каждая строка ti состоит только из строчных букв латинского алфавита.

Выходные данные
Для каждого запроса выведите одну строку — слово из словаря, которое не совпадает с заданным в запросе и имеет с ним максимальную зарифмованность (если таких несколько — выведите любое).
		*/
		//MaxRhyme();
		//__________________________________________Card validation___________________________________________
		/*
		H. Валидация карты (25 баллов)
ограничение по времени на тест1 секунда
ограничение по памяти на тест512 мегабайт
вводстандартный ввод
выводстандартный вывод

В этой задаче вам необходимо реализовать валидацию корректности карты для стратегической компьютерной игры.
Карта состоит из гексагонов (шестиугольников), каждый из которых принадлежит какому-то региону карты. В файлах игры карта представлена как n строк по m символов в каждой (строки и символы в них нумеруются с единицы). Каждый нечетный символ каждой четной строки и каждый четный символ каждой нечетной строки — точка (символ . с ASCII кодом 46); все остальные символы соответствуют гексагонам и являются заглавными буквами латинского алфавита. Буква указывает на то, какому региону принадлежит гексагон.
Вы должны проверить, что каждый регион карты является одной связной областью. Иными словами, не должно быть двух гексагонов, принадлежащих одному и тому же региону, которые не соединены другими гексагонами этого же региона.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

Входные данные
В первой строке задано одно целое число t (1≤t≤100) — количество наборов входных данных.
Первая строка набора входных данных содержит два целых числа n и m (2≤n,m≤20) — количество строк и количество символов в каждой строке в описании карты.
Далее следуют n строк по m символов в каждой — описание карты. Каждый нечетный символ каждой четной строки и каждый четный символ каждой нечетной строки — точка (символ . с ASCII кодом 46); все остальные символы соответствуют гексагонам и являются заглавными буквами латинского алфавита.

Выходные данные
На каждый набор входных данных выведите ответ в отдельной строке — YES, если каждый регион карты представляет связную область, или NO, если это не так.
		*/
		//CardValidation();
	}

	public static void Summator()
	{
		var testCaseCount = int.Parse(Console.ReadLine());
		int a, b;
		for (var i = 0; i < testCaseCount; i++)
		{
			var collection = Console.ReadLine().Split(' ');
			Console.WriteLine(int.Parse(collection[0]) + int.Parse(collection[1]));
		}
	}
	public static void SumForPay()
	{
		var testCaseCount = int.Parse(Console.ReadLine());
		for (int i = 0; i < testCaseCount; i++)
		{
			int productCount = int.Parse(Console.ReadLine());
			var collection = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
			Dictionary<int, int> dict = new Dictionary<int, int>();
			foreach (var item in collection)
			{
				if (dict.ContainsKey(item)) dict[item]++;
				else dict.Add(item, 1);
			}
			int sum = 0;
			foreach (var item in dict)
			{
				sum += item.Key * (item.Value / 3 * 2 + item.Value % 3);
			}
			Console.WriteLine(sum);
		}
	}
	public static void PairProgramming()
	{
		var testCaseCount = int.Parse(Console.ReadLine());
		for (int i = 0; i < testCaseCount; i++)
		{
			int employeeCount = int.Parse(Console.ReadLine());
			var collection = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
			for (int firstEmployeeIndex = 0; firstEmployeeIndex < collection.Length - 1; firstEmployeeIndex++)
			{
				if (collection[firstEmployeeIndex] == 0) continue;
				int diff = int.MaxValue, secondEmployeeIndex = 0;
				for (int k = firstEmployeeIndex + 1; k < collection.Length; k++)
				{
					if (collection[k] == 0) continue;
					if (Math.Abs(collection[firstEmployeeIndex] - collection[k]) < diff)
					{
						diff = Math.Abs(collection[firstEmployeeIndex] - collection[k]);
						secondEmployeeIndex = k;
					}
				}
				Console.WriteLine($"{firstEmployeeIndex + 1} {secondEmployeeIndex + 1}");
				collection[firstEmployeeIndex] = 0;
				collection[secondEmployeeIndex] = 0;
			}
		}
	}
	public static void ElectronicMatrix()
	{
		var testCaseCount = int.Parse(Console.ReadLine());
		for (int i = 0; i < testCaseCount; i++)
		{
			Console.ReadLine();
			var matrixSize = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
			var matrix = new int[matrixSize[0], matrixSize[1]];
			for (int n = 0; n < matrixSize[0]; n++)
			{
				var data = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
				for (int j = 0; j < data.Length; j++) matrix[n, j] = data[j];
			}
			var clickCount = int.Parse(Console.ReadLine());
			var clicks = Console.ReadLine().Split(' ').Select(i => int.Parse(i) - 1).ToArray();
			for (int j = 0; j < clickCount; j++)
			{
				bool flag = true;
				while (flag)
				{
					flag = false;
					for (int n = 1; n < matrixSize[0]; n++)
					{
						if (matrix[n, clicks[j]] < matrix[n - 1, clicks[j]])
						{
							for (int m = 0; m < matrixSize[1]; m++)
							{
								int temp = matrix[n, m];
								matrix[n, m] = matrix[n - 1, m];
								matrix[n - 1, m] = temp;
							}
							flag = true;
						}
					}
				}
			}
			for (int n = 0; n < matrixSize[0]; n++)
			{
				for (int m = 0; m < matrixSize[1]; m++)
				{
					Console.Write(matrix[n, m] + " ");
				}
				Console.WriteLine();
			}
		}
	}
	public static void MyTaskShelduler()
	{
		var processAndTaskCount = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
		var items = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
		Dictionary<long, long> processes = new Dictionary<long, long>();
		for (long i = 0; i < processAndTaskCount[0]; i++) processes.Add(items[i], 0);
		var sortedProcesses = processes.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
		long result = 0;
		for (long i = 0; i < processAndTaskCount[1]; i++)
		{
			var task = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
			long key = -1;
			foreach (var item in sortedProcesses)
			{
				if (item.Value <= task[0])
				{
					key = item.Key;
					break;
				}
			}
			if (key != -1)
			{
				result += key * task[1];
				sortedProcesses[key] = task[1] + task[0];
			}
		}
		Console.WriteLine(result);
	}
	public static void Report()
	{
		var testCaseCount = int.Parse(Console.ReadLine());
		for (int i = 0; i < testCaseCount; i++)
		{
			int workDays = int.Parse(Console.ReadLine());
			var items = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
			Dictionary<int, int> tasks = new Dictionary<int, int>();
			tasks.Add(items[0], 1);
			bool flag = true;
			for (int j = 1; j < items.Length; j++)
			{
				if (items[j] != items[j - 1] && tasks.ContainsKey(items[j]))
				{
					Console.WriteLine("NO");
					flag = false;
					break;
				}
				else if (!tasks.ContainsKey(items[j])) tasks.Add(items[j], 1);
			}
			if (flag) Console.WriteLine("YES");
		}
	}
	public static void PeriodsOfTime()
	{
		var testCaseCount = int.Parse(Console.ReadLine());
		for (int i = 0; i < testCaseCount; i++)
		{
			bool flag = true;
			var periodCount = int.Parse(Console.ReadLine());
			Dictionary<int, (int, int)> periods = new Dictionary<int, (int, int)>();
			for (int j = 0; j < periodCount; j++)
			{
				var period = Console.ReadLine().Split(new char[] { '-', ':' }).Select(i => int.Parse(i)).ToArray();
				if (period[0] < 0 || period[0] > 23 || period[1] < 0 || period[1] > 59 || period[2] < 0 || period[2] > 59 || period[3] < 0 || period[3] > 23 || period[4] < 0 || period[4] > 59 || period[5] < 0 || period[5] > 59)
				{
					flag = false;
				}
				int time1 = period[0] * 3600 + period[1] * 60 + period[2];
				int time2 = period[3] * 3600 + period[4] * 60 + period[5];
				if (time1 > time2)
				{
					flag = false;
				}
				int key = -1;
				bool start = true;
				foreach (var item in periods)
				{
					if ((time1 >= item.Value.Item1 && time1 <= item.Value.Item2) || (item.Value.Item1 >= time1 && item.Value.Item1 <= time2) || time1 == item.Value.Item1 || time1 == item.Value.Item2 || time2 == item.Value.Item1 || time2 == item.Value.Item2)
					{
						flag = false;
						break;
					}
					if (item.Value.Item1 - time2 == 1 && flag) key = item.Key;
					if (time1 - item.Value.Item2 == 1 && flag)
					{
						key = item.Key;
						start = false;
					}
				}
				if (key == -1 || periods.Count == 0)
					periods.Add(j, (time1, time2));
				else if (start)
				{
					int temp = periods[key].Item2;
					periods.Remove(key);
					periods.Add(key, (time1, temp));
				}
				else
				{
					int temp = periods[key].Item1;
					periods.Remove(key);
					periods.Add(key, (temp, time2));
				}
			}
			if (flag) Console.WriteLine("YES");
			else Console.WriteLine("NO");
		}
	}
	public static void MaxRhyme()
	{
		var dictionarySize = int.Parse(Console.ReadLine());
		HashSet<string> dictionary = new HashSet<string>();
		string result = "";
		string res = Console.ReadLine();
		dictionary.Add(res);
		for (int i = 1; i < dictionarySize; i++)
		{
			result = Console.ReadLine();
			dictionary.Add(result);
		}
		var requestCount = int.Parse(Console.ReadLine());
		for (int i = 0; i < requestCount; i++)
		{
			string query = Console.ReadLine();
			int maxRhyme = 0;
			foreach (string word in dictionary)
			{
				if (word != query && word.Length >= maxRhyme && word.Substring(word.Length - maxRhyme) == query.Substring(query.Length - maxRhyme))
				{
					int length1 = query.Length;
					int length2 = word.Length;
					while (maxRhyme < length1 && maxRhyme < length2 && query[length1 - maxRhyme - 1] == word[length2 - maxRhyme - 1])
					{
						maxRhyme++;
						result = word;
					}
				}
			}
			if (query == result) Console.WriteLine(res);
			else Console.WriteLine(result);
		}
	}
	public static void CardValidation()
	{
		var testCaseCount = int.Parse(Console.ReadLine());
		for (int i = 0; i < testCaseCount; i++)
		{
			var cardSize = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
			char[,] card = new char[cardSize[0], cardSize[1]];
			for (int j = 0; j < cardSize[0]; j++)
			{
				var items = Console.ReadLine().ToCharArray();
				for (int k = 0; k < cardSize[1]; k++) card[j, k] = items[k];
			}
			Dictionary<char, int> checkedSymbols = new Dictionary<char, int>();
			bool flag = true;
			for (int n = 0; n < cardSize[0]; n++)
			{
				for (int m = 0; m < cardSize[1]; m += 2)
				{
					if (card[n, m] == '.') m++;
					if (char.IsLower(card[n, m])) continue;
					if (checkedSymbols.ContainsKey(char.ToLower(card[n, m])))
					{
						Console.WriteLine("NO");
						flag = false;
						break;
					}
					CheckSymbol(card, n, m);
					checkedSymbols.Add(card[n, m], 1);
				}
				if (!flag) break;
			}
			if (flag) Console.WriteLine("YES");
		}
	}
	public static void CheckSymbol(char[,] card, int i, int j)
	{
		card[i, j] = char.ToLower(card[i, j]);
		if (j < card.GetUpperBound(1) - 1 && char.ToLower(card[i, j + 2]) == card[i, j] && char.IsUpper(card[i, j + 2])) CheckSymbol(card, i, j + 2);
		if (j > 1 && char.ToLower(card[i, j - 2]) == card[i, j] && char.IsUpper(card[i, j - 2])) CheckSymbol(card, i, j - 2);
		if (i >= 1 && j >= 1 && char.ToLower(card[i - 1, j - 1]) == card[i, j] && char.IsUpper(card[i - 1, j - 1]))
		{
			CheckSymbol(card, i - 1, j - 1);
		}
		if (i < card.GetUpperBound(0) && j < card.GetUpperBound(1) && char.ToLower(card[i + 1, j + 1]) == card[i, j] && char.IsUpper(card[i + 1, j + 1]))
		{
			CheckSymbol(card, i + 1, j + 1);
		}
		if (i >= 1 && j < card.GetUpperBound(1) && char.ToLower(card[i - 1, j + 1]) == card[i, j] && char.IsUpper(card[i - 1, j + 1]))
		{
			CheckSymbol(card, i - 1, j + 1);
		}
		if (i < card.GetUpperBound(0) && j >= 1 && char.ToLower(card[i + 1, j - 1]) == card[i, j] && char.IsUpper(card[i + 1, j - 1]))
		{
			CheckSymbol(card, i + 1, j - 1);
		}
	}
}