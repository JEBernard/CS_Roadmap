<!-- OrderForm.html		Jason Bernard --> 
<!-- Project 2b 	  		      -->
<!-- Calculate Order Total 		      --> 
<!-- ======================================== -->

function Calculate() {

	var Title = document.getElementById('title').value
	var shipping = document.getElementById('shipping').value
	var Name = document.getElementById('name').value; 
	var Address = document.getElementById('address').value; 
	var ZipCode = document.getElementById('zip').value;
	var CityState = document.getElementById('cityState').value 
	var tax = 0.08
	var quantity = document.getElementById('quantity').value;        
	var price = document.getElementById('price').value; 
	var subTotal =quantity * price;
	var SubTotal = document.getElementById('subTotal').value = "$" + subTotal.toFixed(2);
	var salesTax = subTotal * tax;
	var Tax = document.getElementById('salesTax').value = "$" + salesTax.toFixed(2);
	var order = parseFloat(subTotal) + parseFloat(salesTax) + parseFloat(shipping) ; 
	var orderTotal = document.getElementById('orderTotal').value="$" + order.toFixed(2);
	var Summary = document.getElementById('orderSum').value="Your order of " +Title + " will ship within 2 days for a total cost of " +orderTotal+ ".";
	var ShippingAddress = document.getElementById('shippingAddress').value="Your order will ship to " + Name + " at " +Address + " " +CityState +  " " +ZipCode +  ".";
	
	return;

}

function Clear() {

	document.getElementById('title').value="";
	document.getElementById('shipping').value="";
	document.getElementById('name').vaue=""; 
	document.getElementById('address').value=""; 
	document.getElementById('zip').value=""; 
	document.getElementById('cityState').value=""; 
	document.getElementById('quantity').value=""; 
	document.getElementById('price').value=""; 
	document.getElementById('subTotal').value=""; 
	document.getElementById('salesTax').value=""; 
	document.getElementById('orderTotal').value=""; 
	document.getElementById('orderSum').value=""; 
	document.getElementById('name').value="";
	document.getElementById('shippingAddress').value="";
	
	return; 
}