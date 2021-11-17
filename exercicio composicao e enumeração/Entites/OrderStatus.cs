namespace exercicio_composicao_e_enumeração.Entites
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    };
}
