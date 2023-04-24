import java.util.Scanner;
public class Main
{
    // 5.Вводится натуральное число n. На следующей строчке вводятся n целых чисел. Считайте их как массив на n элементов.
    //  Затем вводится число k. Найдите сумму первых k элементов. Гарантируется, что 0 < k <= n.
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
	System.out.println("Введите количество элементов: ");
    int n = sc.nextInt();
    
    
    int[] arr = new int[n];
    System.out.println("Введите элементы:");
	for(int i = 0; i < arr.length; i++){
            arr[i] = sc.nextInt();
    }
    
    System.out.println("Введите любой индекс элемента: ");
    int k = sc.nextInt();
    int count = 0;
    for(int i = 0; i < arr.length; i++){
            if(i<=k){
                count+=arr[i];
            }
    }
    System.out.println("Сумма первых k элементов: " + count);
        
   
	
	
	
    

}  
}


