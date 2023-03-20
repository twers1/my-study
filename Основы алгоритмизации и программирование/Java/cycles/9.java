import java.util.Scanner;
public class Main
{
    // 9. Вводятся натуральное число n. Выведите на экран лесенку, 
    // состоящую из n ступенек. Каждая i-ая ступенька состоит из i звёздочек. 
	public static void main(String[] args) {
            
        Scanner sc = new Scanner(System.in);
        
        
        int n = sc.nextInt();
        
        
        
        for(int i=0;i<n;i++ ){
            for(int j = 0; j <=i;j++){
                System.out.print("*");
            }
            System.out.println(" ");
        }
        
            
        }        
}     


