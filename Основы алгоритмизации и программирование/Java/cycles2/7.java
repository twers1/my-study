import java.util.Scanner;
public class Main
{
    // 7.Напишите программу, которая находит сумму квадратов натуральных чисел 
    //  от 1 до n, где n вводится с клавиатуры.
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int s =2;// степень 2
        int sum=0;
       for(int i= 1;i<=n;i++ ){
            sum+=Math.pow(i, s);
        }
            System.out.print(sum);
}  
}


