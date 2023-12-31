﻿/*
 * Version for Unity
 * © 2015-2020 YANDEX
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * https://yandex.com/legal/appmetrica_sdk_agreement/
 */

using System;

[Serializable]
public struct YandexAppMetricaRevenue
{
    [Obsolete("Outdated constructor. Use the YandexAppMetricaRevenue(decimal priceDecimal, string currency) instead.")]
    public YandexAppMetricaRevenue(double price, string currency) : this()
    {
        Price = price;
        PriceDecimal = null;
        Quantity = null;
        Currency = currency;
        ProductID = null;
        Receipt = null;
        Payload = null;
    }

    public YandexAppMetricaRevenue(decimal priceDecimal, string currency) : this()
    {
        Price = null;
        PriceDecimal = priceDecimal;
        Quantity = null;
        Currency = currency;
        ProductID = null;
        Receipt = null;
        Payload = null;
    }

    [Obsolete("The field is deprecated. Use the PriceMicros field instead.")]
    public double? Price { get; private set; }

    public decimal? PriceDecimal { get; private set; }

    public string Currency { get; private set; }

    public int? Quantity { get; set; }

    public string ProductID { get; set; }

    public YandexAppMetricaReceipt? Receipt { get; set; }

    public string Payload { get; set; }
}


[Serializable]
public struct YandexAppMetricaReceipt
{
    public string Data { get; set; }

    public string Signature { get; set; }

    public string TransactionID { get; set; }
}
