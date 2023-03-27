import java.util.Scanner;
public class Main
{
    // 6.Напишите программу, которая находит сумму квадратов натуральных чисел
    //  от 1 до n, где n вводится с клавиатуры.
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int x =1;
        int sum=0;
        while (x<=n){
            sum+=x++;
        }
            System.out.print(sum);
}  
}


