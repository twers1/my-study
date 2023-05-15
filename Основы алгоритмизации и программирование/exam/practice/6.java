import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   //6. Напишите программу, действием которой будет создание массива и заполнение его цифрами от 100 до 80.
	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
    
        int[] arr = new int[101];
        
      
        for(int i=100; i>=80; i--){
            arr[i] = i;
        }
        
        for(int i=100; i>=80; i--){
            System.out.println(arr[i]);
        }

}  
}


