package co.edu.uptc.java.doubleList;

public class NodeDoubleList<T> {

    private T data;
    private NodeDoubleList<T> previous;
    private NodeDoubleList<T> next;

    public NodeDoubleList(T data) {

        this.data = data;

        previous = null;
        next = null;
    }

    public T getValue() {
        return data;
    }

    public void setValue(T data) {
        this.data = data;
    }

    public NodeDoubleList<T> getPrevious() {
        return previous;
    }

    public void setPrevious(NodeDoubleList<T> previous) {
        this.previous = previous;
    }

    public NodeDoubleList<T> getNext() {
        return next;
    }

    public void setNext(NodeDoubleList<T> next) {
        this.next = next;
    }
}