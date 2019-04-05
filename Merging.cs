using System;
namespace MergeSort
{
    class Merging
    {


        public static int[] mergeSort(int[] arr){
            
            if(arr.Length == 1){
                return arr;
            } 
            
            int mid = arr.Length/2;            
            
            int[] leftArray = new int[mid];
            for(int i = 0; i < mid; i++){
                leftArray[i] = arr[i];
            }
            int[] rightArray = new int[arr.Length - mid];
            for(int i = mid, j = 0; i < arr.Length; i++, j++){
                rightArray[j] = arr[i];
            }

            int[] lArray = mergeSort(leftArray);
            
            int[] rArray = mergeSort(rightArray);
            
            return sortValues(lArray, rArray);

        }

        public static int[] sortValues(int[] arr1, int[] arr2)
        {
            int[] newArray = new int[arr1.Length + arr2.Length];
            int r1 = 0, r2 = 0, i = 0;
            while(r1 < arr1.Length && r2 < arr2.Length){
                if(arr1[r1] < arr2[r2]){
                    newArray[i] = arr1[r1];
                    r1++;
                } else if(arr1[r1] > arr2[r2]){
                    newArray[i] = arr2[r2];
                    r2++;
                }
                i++;
            }           
            while(r1 < arr1.Length){
                newArray[i] = arr1[r1];
                r1++;
                i+=1;
            }
            while(r2 < arr2.Length){
                newArray[i] = arr2[r2];
                r2++;
                i++;   
            }
            return newArray;
        } 


    }
}
