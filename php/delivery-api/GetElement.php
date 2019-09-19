// DocSection: delivery_api_get_element
<?php
// Tip: Find more about PHP SDKs at https://developer.kenticocloud.com/docs/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use KenticoCloud\Delivery\DeliveryClient;

$client = new DeliveryClient('975bf280-fd91-488c-994c-2f04416e5ee3');

$element = $client->getElement('coffee', 'processing');
// EndDocSection