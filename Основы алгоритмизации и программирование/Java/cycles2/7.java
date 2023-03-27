import java.util.Scanner;
public class Main
{
    // 7.Составьте программу, которая запрашивает ввод n чисел и считает их произведение. 
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        double sum = 1;
        for(int i=0;i<n;i++){
            double a = sc.nextInt();
            sum*=a;

        }
        System.out.println(sum);
}  
}


