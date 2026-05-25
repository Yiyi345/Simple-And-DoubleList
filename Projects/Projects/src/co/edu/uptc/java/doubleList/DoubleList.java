package co.edu.uptc.java.doubleList;

public class DoubleList<T> {

    private NodeDoubleList<T> head;
    private int size;

    public DoubleList() {
        head = null;
        size = 0;
    }

    public int size() {

        if (size == Integer.MAX_VALUE) {
            return Integer.MAX_VALUE;
        }

        return size;
    }

    public boolean isEmpty() {
        return size == 0;
    }

    public boolean contains(Object o) {

        if (o == null) {
            throw new NullPointerException("La lista no permite datos nulos");
        }

        NodeDoubleList<T> auxNode = head;

        while (auxNode != null) {

            if (auxNode.getValue().equals(o)) {
                return true;
            }

            auxNode = auxNode.getNext();
        }

        return false;
    }

    public Object[] toArray() {

        if (isEmpty()) {
            return new Object[0];
        }

        Object[] array = new Object[size];

        NodeDoubleList<T> current = head;

        int index = 0;

        while (current != null) {

            array[index] = current.getValue();

            current = current.getNext();

            index++;
        }

        return array;
    }

    public boolean add(T e) {

        NodeDoubleList<T> newNode = new NodeDoubleList<>(e);

        if (head == null) {

            head = newNode;
        }
        else {

            NodeDoubleList<T> current = head;

            while (current.getNext() != null) {
                current = current.getNext();
            }

            current.setNext(newNode);

            newNode.setPrevious(current);
        }

        size++;

        return true;
    }

    public boolean remove(Object o) {

        if (head == null) {
            return false;
        }

        if (head.getValue().equals(o)) {

            head = head.getNext();

            if (head != null) {
                head.setPrevious(null);
            }

            size--;

            return true;
        }

        NodeDoubleList<T> aux = head;

        while (aux != null) {

            if (aux.getValue().equals(o)) {

                aux.getPrevious().setNext(aux.getNext());

                if (aux.getNext() != null) {
                    aux.getNext().setPrevious(aux.getPrevious());
                }

                size--;

                return true;
            }

            aux = aux.getNext();
        }

        return false;
    }

    public T get(int index) {

        if (index < 0 || index >= size) {
            throw new IndexOutOfBoundsException("Índice fuera de rango: " + index);
        }

        NodeDoubleList<T> aux = head;

        for (int i = 0; i < index; i++) {
            aux = aux.getNext();
        }

        return aux.getValue();
    }
}