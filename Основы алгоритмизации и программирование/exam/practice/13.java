import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 13. Напишите программу, действием которой будет рисование таблицы n x 5 состоящую из числа n, введенного пользователем.

   
	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите число ");
        int n = sc.nextInt();
        
        int multiply = 0;
        for(int i = 1; i<=5; i++){
            multiply = i*n;
            System.out.println("Ответ на задание: " + multiply);
        }
            

}  
}


