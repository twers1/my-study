import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 16. Напишите программу, которая проверяет является ли число, введенное пользователем трехзначным.

   
	public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите любое число");
        int n = sc.nextInt();
        
        if(n>100 && n<1000){
            System.out.println("Число является трехзначным");
        }
        else {
            System.out.println("nope");
        }

}  
}


