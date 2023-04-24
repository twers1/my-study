import java.util.Scanner;
public class Main
{
    // 4.Вводится натуральное число n. На следующей строчке вводятся n целых чисел. Считайте их как массив на n элементов. 
    // Затем вводится число k. Найдите количество элементов в массиве равных k. 
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
            if(k == arr[i]){
                count++;
            }
    }
    System.out.println(count);
        
   
	
	
	
    

}  
}


