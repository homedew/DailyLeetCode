function maxScore(s: string): number {
    let ans = 0;

    for(let i = 0; i < s.length - 1; i ++) {
       let curr = 0;
       for(let j = 0; j <= i; j++) {
            if(s.charAt(j) == '0'){
                curr++;
            }
       }

       for(let j = i + 1; j < s.length; j++) {
        if(s.charAt(j) == '1') {
            curr++;
        }
       }

       ans = Math.max(ans, curr);
    }

    
    return ans;
};