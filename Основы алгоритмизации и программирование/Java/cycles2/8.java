import java.util.Scanner;
public class Main
{
    // 8.Составьте программу, которая в одну строку через пробел выводит все нечетные цифры.
	public static void main(String[] args) {
            Scanner sc = new Scanner(System.in);
            int n = sc.nextInt();
        for(int i = 1; i<=n;i++){
            if(i % 2 !=0) {
                System.out.println(i + " ");
            }
        }
}  
}


