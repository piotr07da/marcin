Symulator

SILNIK:
Symulator oparty jest na silniku. Kod silnika jest w namespace Simul.Engine.
Silnik składa się z:
1. Komponentów - klasa Component
   - komponenty można zagnieżdżać i tym samym tworzyć drzewiastą strukturę komponentów.
   - komponenty mogą posiadać zachowania - implementacje klasy IBehavior.
   - komponenty posiadają Transform czyli informację o położeniu (być może w przyszłości także rotacji i skali, ale narazie wystarczy położenie).
2. Zachowań - klasy implementujące interfejs IBehavior - dzięki zachowaniom można implementować konkretną / dowolną symulację / grę. W silniku przygotowano klika uniwersalnych zachowań takich jak:
   - CircleRenderer i FrameRenderer służące do rysowania na canvasie
   - RigidBody - reprezentuje bryłę sztywną (https://en.wikipedia.org/wiki/Rigid_body) i służy do przeprowadzania symulacji fizyki.
     Obecna implementacja wspiera jedynie prędkość. Przypięcie RigidBody do komponentu pozwala na przemieszczanie komponentu dzięki wspólnej referencji do obiektu klasy Transform.
   Implementacja nowego zachowania pozwala na zdefiniowanie:
   - w metodzie Init co ma się wydarzyć w chwili dopinania zachowania do komponentu (metoda AppendBehavior).
     Metoda Init przyjmuje komponent będący właścicielem zachowania - dzięki temu dane zachowanie może do swojego właściciela (komponentu do którego jest przypięte) dopinać więcej zachowań.
   - w metodzie Update co ma się wydarzyć w każdej klatce fizyki/animacji (dla uproszczenia obecny silnik nie definiuje rozgraniczenia pomiędzy klatką fizyki, a klatką animacji).
     Metoda Update przyjmuje deltę czasu pomiędzy aktualną, a poprzednią klatką - jest to szczególnie przydatne przy symulacji fizyki - patrz zachowanie RigidBody gdzie zaimplementowane jest ciągłe integrowanie (całkowanie/sumowanie) po czasie (dt).
3. Klasy Runner czyli mechanizmu wykonującego cyklicznie z zadanym odstępem czasu wszystkich metod Update na wszystkich zachowaniach (IBehavior) przypiętych do wszystkich komponentów w całym drzewie komponentów
   poczynając od rootowego komponentu przekazanego do metodu Run.

KONKRETNE ZASTOSOWANIE: Symulator życia populacji stworków:
W namespace Simul.World można znaleźć aktualnie zaimplementowane zachowania dla naszej konkretnej symulacji życia stworków.
Creature - stworek
SimulatorRoot - komponent rootowy przekazywany do silnika do metody Run

