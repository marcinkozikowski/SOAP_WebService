
package org.jg.rsi;

import java.util.LinkedList;
import java.util.List;
import javax.jws.WebService;

@WebService(endpointInterface = "org.jg.rsi.HelloWorld")
public class HelloWorldImpl implements HelloWorld {

    @Override
    public String getHelloWorldAsString(String name) {
        return "Witaj świecie JAX-WS: "+name;
    }

    @Override
    public List<Product> getProducts() {
        List<Product> productsList = new LinkedList<Product>() {};
        for(int i=0;i<20;i++)
        {
            productsList.add(new Product(("Produkt "+i),("Opis produktu "+i),(10+i)));
        }
        return productsList;
    }
    
}
