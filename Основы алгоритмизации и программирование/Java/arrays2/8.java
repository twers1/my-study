import java.util.Scanner;
import java.util.stream.IntStream;
public class Main
{
    // 8.Вводится натуральное число n. На следующей строчке вводятся n целых чисел. Напишите код, 
    // который создаст массив с именем array на n элементов, в котором буду храниться введённые числа 
    // (элемент массива равен соответствующему числу в во второй строке). На следующей строке вводится 2 числа - 
    // индексы элементов, сумму которых вам надо найти. Выведите на экран сумму этих двух элементов. 
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
	System.out.println("Введите количество элементов:");
    int n = sc.nextInt();
    int[] arr = IntStream.rangeClosed(0, n-1).toArray();
    System.out.println("Введите элементы:");
	for (int i = 0; i < arr.length; i++) {
	    arr[i] = sc.nextInt();
        // System.out.println(arr[i]);
	} // проверка первой части задачи 
    System.out.println("Введите мне 2 числа(индексы элементов, сумму который мне надо найти): ");
    int a = sc.nextInt();
    int b = sc.nextInt();
    System.out.println(arr[a] + arr[b]);
	
	
	
    

}  
}


