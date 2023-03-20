import java.util.Scanner;
public class Main
{
    // 5.Пользователь вводит натуральное число n. Вывести сумму всех кубов до n
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt(); // 5
        int i = 1;
        int sum = 0;
        
        while(i<=n) {
            sum+=Math.pow(i, 3);
            i++;
            
        }
        System.out.println(sum); // 225
            
        }        
}     


