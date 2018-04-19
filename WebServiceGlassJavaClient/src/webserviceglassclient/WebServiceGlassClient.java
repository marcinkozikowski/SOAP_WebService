/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package webserviceglassclient;

import java.util.List;
import org.jg.rsi.HelloWorld;
import org.jg.rsi.HelloWorldImplService;
import org.jg.rsi.Product;

/**
 *
 * @author Dell
 */
public class WebServiceGlassClient {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        HelloWorldImplService service = new HelloWorldImplService();
        HelloWorld hw = service.getHelloWorldImplPort();
        
        List<Product> list = hw.getProducts();
        
        for(int i=0;i<list.size();i++)
        {
            System.out.println(list.get(i).getNazwa()+" "+list.get(i).getOpis()+" "+list.get(i).getCena());
        }
    }
    
}
