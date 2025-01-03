function waysToSplitArray(nums: number[]): number {
    let n: number = nums.length;    
    let prefixSum: number[] = new Array(n);
    prefixSum[0] = nums[0];

    for(let i = 1; i < n; i++) {
        prefixSum[i] = prefixSum[i - 1] + nums[i];
    }

    let count: number = 0;

    for(let i = 0; i < n - 1; i ++) {
        let leftSum: number = prefixSum[i];
        let rightSum: number = prefixSum[n - 1] - prefixSum[i];

        if(leftSum >= rightSum) {
            count++;
        }

    }

    return count;
};