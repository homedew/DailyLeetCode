function maxScore2(s: string): number {
    let ans: number = 0;
    let ones: number = 0;
    let zeros: number = 0;

    for(let i = 0; i< s.length; i++) {
        if(s.charAt(i) == '1') ones++;
    }

    for(let i = 0; i < s.length - 1; i++) {
        if(s.charAt(i) == '1') {
            ones--;
        } else {
            zeros++;
        }

        ans = Math.max(ans, ones + zeros);
    }

    return ans;
};