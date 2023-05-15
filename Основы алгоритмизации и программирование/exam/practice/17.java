import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 17. Пользователь вводит 5 целых чисел. Напишите программу, которая выводит их среднее арифметическое.

   
	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите 5 любых чисел: ");
        int n = sc.nextInt();
        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();
        int d = sc.nextInt();
        
        int avg = (n+a+b+c+d)/5;
        
        System.out.println("Среднее арифметическое: " + avg);
            

}  
}


