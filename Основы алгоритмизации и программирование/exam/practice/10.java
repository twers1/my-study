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
        
        int multiply = 1;
        while(a!=0){
            int temp = a%10;
            multiply *= temp;
            a /=10;
        }
        
        System.out.println(multiply);
        
            

}  
}


