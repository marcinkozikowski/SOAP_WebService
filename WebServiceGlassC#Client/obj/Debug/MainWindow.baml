   M S B A M L   `   `   `  ����K  GWebServiceClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WebServiceClientWebServiceClient  5   	   !    WebServiceClient.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WebServiceClient     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5        $��nameTextBox��5      $��0��6%   $��0��65   $��wpisz cos...��6B   �� 5   
   -   5        $��nameBTN��5   M   $��1��6   $��0��6   $��getName(String name)��6.   6\   �� 5   
   -   5        $��
productBTN��5   F   $��1��6   $��1��6   $��getProducts()��6.   6X   �� 5   
   -   5        $��	nameLabel��5   -   $��0��6   $��2��6    6-   �� 5   
   -   5        $��productsLabel��5   -   $��1��6   $��2��6    6-   5      5      