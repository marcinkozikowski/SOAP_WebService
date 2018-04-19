/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package org.jg.rsi;

/**
 *
 * @author Dell
 */
public class Product {
    String nazwa;
    String opis;

    public String getNazwa() {
        return nazwa;
    }

    public void setNazwa(String nazwa) {
        this.nazwa = nazwa;
    }

    public String getOpis() {
        return opis;
    }

    public void setOpis(String opis) {
        this.opis = opis;
    }

    public int getCena() {
        return cena;
    }

    public void setCena(int cena) {
        this.cena = cena;
    }
    int cena;
    
    public Product(String _nazwa,String _opis,int _cena)
    {
        nazwa=_nazwa;
        opis=_opis;
        cena=_cena;
    }
    
}
