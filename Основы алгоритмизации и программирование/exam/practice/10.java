import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 10. Дано натурально число. Напишите программу, вычисляющую произведение цифр этого числа.
   
	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите число ");
        int a = sc.nextInt();
        
        int multiply = 0;
        for(int i=0; i<=9; i++){
            multiply = i*a;
            System.out.println("Ответ на задание: " + multiply);
        }
        
            

}  
}


