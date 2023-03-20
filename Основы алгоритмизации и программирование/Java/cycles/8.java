import java.util.Scanner;
public class Main
{
    // 8. Вводятся два целых числа k и n Выведите на экран построчно 
    // все числа кратные k от 1 до n включительно. 
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        
        int k = sc.nextInt(); 
        int n = sc.nextInt();
        int i = k; // переменная нужна для того, чтобы он показывал числа, которые делятся на k
        
        while(i <= n) {
            System.out.println(i);
            i+=k;
        }
        
            
        }        
}     


