import java.util.Scanner;
public class Main
{
    // 4. Вводится 2 целых числа a и b (a <= b). Необходимо вывести  
    // все четные цифры
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        
        int a = sc.nextInt();
        int b = sc.nextInt(); 
        
        
        while(a<=b) { 
           if(a%2 == 0) {
               System.out.println(a);
           }
           a++; // чтобы не было бесконечного цикла
        }
           
    }
        
}

