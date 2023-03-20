import java.util.Scanner;
public class Main
{
    // 7. Вводится число натуральное число n. 
    // Выведите на экран построчно все числа от 1 до n. 
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt(); 
        int i = 1;
        
        while(i<=n) {
            System.out.println(i);
            i++;
        }
        
            
        }        
}     


