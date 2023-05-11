import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 14. Напишите программу, действием которой будет заполнение одномерного массива числами, которые вводит пользователь 
   // и выводом на экран суммы его элементов.

   
	public static void main(String[] args) {
	    
	    Scanner sc = new Scanner(System.in);
        System.out.println("Введите количество элементов в массиве: ");
        int n = sc.nextInt();
        int[] arr = new int[n];
        
        System.out.println("Введите элементы: ");
        for(int i=1; i< arr.length; i++5
        ){
            arr[i] = sc.nextInt();
        }
        
        System.out.println("Ищу сумму: ");
        int sum = 0;
        for(int i=1; i< arr.length; i++){
            sum+=arr[i];
        }
        System.out.println("Сумма: " + sum);
            

}  
}


