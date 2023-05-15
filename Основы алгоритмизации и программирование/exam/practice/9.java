import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 9. Напишите программу, где пользователь вводит два целых числа a и b, необходимо вычислить произведение 
   // всех чисел от a до b включительно
	public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите два числа ");
        int a = sc.nextInt();
        int b = sc.nextInt();
        
        int multiply = 1;
        for(int i = a; i <=b; i++){
            multiply *= i ;
        }
        System.out.println("Ответ на задание: " + multiply);
            

}  
}


