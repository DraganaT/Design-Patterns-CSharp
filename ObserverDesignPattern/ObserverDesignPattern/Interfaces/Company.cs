namespace ObserverDesignPattern.Interface
{
    interface Company 
    {
        void registerObserver(Observer o);

        void removeObserver(Observer o);

        void notifyObservers();
    }
}
