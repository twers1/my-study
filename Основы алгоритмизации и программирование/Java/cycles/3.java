import java.util.Scanner;
public class Main
{
    // 3. Вводится 2 целых числа a и b (a <= b). Необходимо вычислить количество
    // всех чисел кратных 5, но не кратных 4 от а до b включительно.
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        
        int a = sc.nextInt(); // 1
        int b = sc.nextInt(); // 25
        int quantity = 0;
        
        while(a<=b) { 
           if(a%5==0 && a%4 !=0) {
               quantity++;
           }
           a++; // чтобы не было бесконечного цикла
        }
        System.out.println(quantity); // 4
        
    }
}
