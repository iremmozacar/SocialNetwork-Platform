using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Basket
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid ProductId { get; private set; }
    public int Quantity { get; private set; }
    public ICollection<BasketItem> BasketItems { get; set; }
    public User User { get; set; }

    public Basket(Guid userId, Guid productId, int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Ürün miktarı sıfırdan büyük olmalıdır.");

        Id = Guid.NewGuid();
        UserId = userId;
        ProductId = productId;
        Quantity = quantity;
    }

    public void UpdateQuantity(int newQuantity)
    {
        if (newQuantity <= 0)
            throw new ArgumentException("Yeni miktar sıfırdan büyük olmalıdır.");
        Quantity = newQuantity;
    }
}
