namespace Lists;


class Lists{
    public int max(List<int> Numbers){
        int BiggestNumber = Numbers[0];
        int SeccondBiggest = Numbers[1];
        foreach(int Num in Numbers){
            if(Num > BiggestNumber){
                BiggestNumber = Num;
            }
        }
        return BiggestNumber;
    }

}