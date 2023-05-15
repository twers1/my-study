import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 12. Напишите программу, действием которой будет подсчет 3 в числе, введённом пользователем.

   
	public static void main(String[] args) {
        
        int x = 3333;
        int q = 0;
        
        while(x!=0){
          int n = x%10;
          if (n == 3){
              q++;
          }
          x /= 10;
        }
        System.out.println(q);

}  
}


