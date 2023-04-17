import java.util.Scanner;
import java.util.stream.IntStream;
public class Main
{
    // 6.Вводится натуральное число n. Напишите код, который создаст массив с именем array на n элементов, 
    // в котором буду храниться числа от 0 до n - 1 (элемент равен индексу).
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
	System.out.println("Введите количество элементов:");
    int n = sc.nextInt();
    int[] arr = IntStream.rangeClosed(0, n-1).toArray();
    System.out.println("Введите элементы:");
	for (int i = 0; i < n; i++) {
	    arr[i] = sc.nextInt();
        arr[i] = i;
	}
	System.out.println("Ответ задания: ");
	for (int i = 0; i < arr.length; i++) {
	    System.out.println(arr[i]);
	}
	
	
    

}  
}


