package co.edu.uptc.java.simpleList;

public class SimpleList<T> {
    private Node<T> head;

    public SimpleList() {
        head = null;
    }

    public SimpleList(Node<T> head) {
        this.head = head;
    }

    public boolean add(T data) {
        Node<T> newNode = new Node<>(data);
        if (head == null) {
            head = newNode;
        } else {
            Node<T> temporalNode = head;
            while (temporalNode.getNext() != null) {
                temporalNode = temporalNode.getNext();
            }
            temporalNode.setNext(newNode);
        }
        return true;
    }

    public T get(int index) {
        Node<T> temporalNode = head;
        if (index >= 0 && index < size()) {
            for (int i = 0; i <= index; i++) {
                if (index == i) {
                    return temporalNode.getValue();
                }
                temporalNode = temporalNode.getNext();

            }
        }

        return null;
    }

    public int size() {
        Node<T> temporalNode = head;
        int size = 0;
        while (temporalNode != null) {
            size++;
            temporalNode = temporalNode.getNext();
        }
        return size;
    }

    public boolean isEmpty() {
        return head == null;
    }

    public boolean remove(Object o) {
        boolean isFounded = false;
        Node<T> actual = head;
        Node<T> previous = head;

        if (head != null && head.getValue().equals(o)) {
            head = head.getNext();
            isFounded = true;
        } else {
            while (actual != null && !isFounded) {
                if (actual.getValue().equals(o)) {
                    previous.setNext(actual.getNext());
                    isFounded = true;
                } else {
                    previous = actual;
                    actual = actual.getNext();
                }
            }
        }
        return isFounded;
    }

    public boolean contains(Object o) {
        Node<T> temporalNode = head;

        while (temporalNode != null) {
            if (o == null) {
                if (temporalNode.getValue() == null) {
                    return true;
                }
            } else {
                if (o.equals(temporalNode.getValue())) {
                    return true;
                }
            }
            temporalNode = temporalNode.getNext();
        }

        return false;
    }

}
