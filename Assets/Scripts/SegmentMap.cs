public static class SegmentMap {

    // Map of which segments to turn on
    // Goes clockwise starting from top center, ending in dead center

    public static int[] ZERO = {0, 1, 2, 3, 4, 5 };
    public static int[] ONE = {1, 2};
    public static int[] TWO = { 0, 1, 6, 4, 3 };
    public static int[] THREE = { 0, 1, 6, 2, 3 };
    public static int[] FOUR = { 1, 2, 6, 5 };
    public static int[] FIVE = { 0, 5, 6, 2, 3 };
    public static int[] SIX = { 0, 5, 6, 4, 3, 2 };
    public static int[] SEVEN = { 0, 1, 2 };
    public static int[] EIGHT = { 0, 1, 2, 3, 4, 5, 6 };
    public static int[] NINE = { 0, 1, 2, 3, 5, 6 };

    public static int[] GetSegmentMap (int number) {
        switch (number) {
            case 0:
                return SegmentMap.ZERO;
            case 1:
                return SegmentMap.ONE;
            case 2:
                return SegmentMap.TWO;
            case 3:
                return SegmentMap.THREE;
            case 4:
                return SegmentMap.FOUR;
            case 5:
                return SegmentMap.FIVE;
            case 6:
                return SegmentMap.SIX;
            case 7:
                return SegmentMap.SEVEN;
            case 8:
                return SegmentMap.EIGHT;
            case 9:
                return SegmentMap.NINE;
            default:
                return SegmentMap.ZERO;
        }
    }
}
