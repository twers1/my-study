import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 20. Напишите программу, где пользователь вводит два целых числа a и b, необходимо вычислить сумму всех чисел 
   // от a до b включительно


   
	public static void main(String[] args) {
       Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        int b = sc.nextInt();
        int sum =0;
        for(int i =a; i<=b; i++){
            sum +=i;
        }
        
        System.out.println(sum);

}  
}

