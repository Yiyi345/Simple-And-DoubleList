package co.edu.uptc.java.simpleList;

public class TestSimpleList {

    private static final int SIZE = 10000;

    public static void main(String[] args) {

        Runtime runtime = Runtime.getRuntime();
        runtime.gc();

        long memoryBeforeAdd = runtime.totalMemory() - runtime.freeMemory();

        long startAdd = System.nanoTime();

        SimpleList<Integer> addList = new SimpleList<>();

        for (int i = 0; i < SIZE; i++) {
            addList.add(i);
        }

        long endAdd = System.nanoTime();

        long memoryAfterAdd = runtime.totalMemory() - runtime.freeMemory();



        SimpleList<Integer> containsList = new SimpleList<>();

        for (int i = 0; i < SIZE; i++) {
            containsList.add(i);
        }

        long startContains = System.nanoTime();

        containsList.contains(SIZE - 1);

        long endContains = System.nanoTime();



        runtime.gc();

        long memoryBeforeRemove = runtime.totalMemory() - runtime.freeMemory();

        SimpleList<Integer> removeList = new SimpleList<>();

        for (int i = 0; i < SIZE; i++) {
            removeList.add(i);
        }

        long startRemove = System.nanoTime();

        removeList.remove(SIZE / 2);

        long endRemove = System.nanoTime();

        long memoryAfterRemove = runtime.totalMemory() - runtime.freeMemory();



        System.out.println("| Method   | Time(ns) | Time(ms) | Memory(bytes) |");

        System.out.println(
                "| Add      | "
                        + (endAdd - startAdd)
                        + " | "
                        + ((endAdd - startAdd) / 1_000_000.0)
                        + " | "
                        + (memoryAfterAdd - memoryBeforeAdd)
                        + " |"
        );

        System.out.println(
                "| Contains | "
                        + (endContains - startContains)
                        + " | "
                        + ((endContains - startContains) / 1_000_000.0)
                        + " | 0 |"
        );

        System.out.println(
                "| Remove   | "
                        + (endRemove - startRemove)
                        + " | "
                        + ((endRemove - startRemove) / 1_000_000.0)
                        + " | "
                        + (memoryAfterRemove - memoryBeforeRemove)
                        + " |"
        );
    }
}