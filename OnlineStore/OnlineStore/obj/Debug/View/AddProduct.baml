   M S B A M L   `   `   `  ����F  BOnlineStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OnlineStore.ViewOnlineStore.View  5   	   !    OnlineStore.View.AddProduct   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:OnlineStore.View     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
AddProduct��5	   	   $	��710��6   $	��650��6)    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K    � 	Resources 5
       �� 
TargetType 
  Labels �� Property �� Value  	TextBoxes��%�  &	        &	     �� 5   
   " ��6   .�5      ��  � ��$ Franklin Gothic)�6+   6E   �� 5       � �� �#9825516=   �� 5       � ��$ 20(�6)   66   �� 5       � ��$ Center=�62   6C   �� 5       � ��$ 25q�6'   64   5      �� 5   
   " ��6   .�5      ��  � �� �#9825516>   �� 5       � ��$ 2q�60   6<   �� 5       � ��
 �����6;   �� 5       � ��$ Franklin Gothic)�6+   6E   �� 5       � �� �#9825516=   �� 5       � ��$ 18(�6)   66   �� 5       � ��$ 25��6'   64   �� 5       � ��$	 200��6&   64   �� 5       � ��$ 0,0,20,0q�6'   6:   5      5      .��5      �  � RowDefinitions 5   
   �� 5       $��50 �6   �� 5!      $��90 �6   �� 5"      $��90 �6   �� 5#      $��90 �6   �� 5$      $	��300 �6   �� 5%      $��80 �6    � ColumnDefinitions 5'   
   �� 5(      $��50 �6   �� 5)      $	��300 �6   �� 5*      $	��300 �6   .+�5,   
   �� $8��2ДОБАВЛЕНИЕ НОВОГО ПРОДУКТА��6   
�������$��1��6I   $��2��6Y   $��0��6m   $��Franklin Gothic)�6z   $��28(�6�   $��Center=�6�   $��Center=�6�   ���#9825516�   �� 5-   
   $��0��6   $��0��6%   $��6��62   ���#80304c.+�5.      �� -   5        $��50��5.      ���#80304c��66   Z� .��5/      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6*   $��Center=�6E   $��30��6b   $��30��6m   	   Kind$	 Account=�6y   50      51      �� 52   
   $��0,0,0,0q�6   $��0��6&   $��5��66   .+�53      �� -   5        $��50��53      $��50��6    ���#80304c��6A   Z� .��54        $��Center=�6*   $��Center=�6E   $��20��6b   $��20��6m   $	 Power=�6y   55      56      �� 57   
   $��1��6   $��1��6"   $��5��62   $��2��6C   
�������.+�58      �� $	��700��6   ��59      �� 5:      
 �� 
StartPoint$
 0.5,0&�6*    �� EndPoint$ 0.5,1&�6=   .��5;      �  � Color$ #FADFAD��6'    � Offset$	 0.9Q�67   � 5<      $ #FFDAB9��6'   $	 0.6Q�67   � 5=      $ #FFCFAB��6'   $	 0.3Q�67   5>      5@      5A      �� 5B   
   $��1��6   $��1��6   $(��"НАЗВАНИЕ ПРОДУКТА:��6-   #���   6J   �� 5C   
   $��2��6   $��1��6   $ ��ЦЕНА ПРОДУКТА:��6-   #���   6F   �� 5D   
   $��3��6   $��1��6   $,��&КОЛИЧЕСТВО ПРОДУКТА:��6-   #���   6L   �� 5E   
   $��4��6   $��1��6   $.��(ИЗОБРАЖЕНИЕ ПРОДУКТА:��6-   #���   6M   �� 5F   
   $��2��6   $��
0,-50,20,0q�6%   $	��200��69   $	��200��6E   $��4��6R   $��2��6_   .+�5G      �� -   5         ��Name$ ItemPicture��5G      $��Icons/product.png��6)   �� 5H      -   5        $ MainItemPicture��5H      $	��200q�6-   $��Icons/product.png��6:   5I      �� 5J   
   $��4��6   $��2��6"   .+�5K      �� -   5        ���#982551$��
0,240,20,0q�5K   *   $	��220��6>   $��18(�6J   $��Franklin Gothic)�6X   $-��'Добавить изображение��6�   5L      �� 5M   
   -   5         ��Name$ Name_TextBox��5M      $��1��6(   $��2��65   #���  6E   �� 5N   
   -   5        $ Price_TextBox��5N      $��2��6)   $��2��66   #���  6F   �� 5O   
   -   5        $ Quantity_TextBox��5O      $��3��6,   $��2��69   #���  6I   �� 5P   
   $��5��6   $��1��6"   $��2��62   .+�5Q      �� -	   5        ���#982551$��5q�5Q   *   $	��250��65   $��35��6A   $��18(�6M   $��Franklin Gothic)�6[   $%��ДОБАВИТЬ ПРОДУКТ��6�   5R      5S      5T      