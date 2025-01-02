function vowelStrings(words: string[], queries: number[][]): number[] {
    const n: number = words.length;
    const prefix: number[] = new Array(n + 1).fill(0);

    for(let i = 0; i < n; i++) {
        if(isVowelString(words[i])) {
            prefix[i + 1] = prefix[i] + 1;
        } else {
            prefix[i + 1] = prefix[i];
        }
    }

    const result: number[] = [];
    
    for(const[l, r] of queries) {
        result.push(prefix[r + 1] -prefix[l]);
    }

    return result;

};

function isVowel(c: string): boolean {
    return "aeiou".includes(c);
}

function isVowelString(word: string): boolean {
    return isVowel(word[0]) && isVowel(word[word.length - 1]);
}