// Design 1
using AbstractFactory.Design1;

ICarFactory factory = new NissanFactory();
factory.GetEngine().CreateEngine();
factory.GetHeadLight().CreateHeadLight();
